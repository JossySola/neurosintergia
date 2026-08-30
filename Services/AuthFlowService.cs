using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using neurosintergia.Data;
using System.Security.Cryptography;

namespace neurosintergia.Services;

public interface IUserProfile
{
    string Id { get; set; }
    string Email { get; set; }
}
public class AuthFlowService(
    UserManager<ApplicationUser> userManager,
    IDbContextFactory<ApplicationDbContext> contextFactory,
    HttpClient httpClient
)
{
    private readonly UserManager<ApplicationUser> UserManager = userManager;
    private readonly IDbContextFactory<ApplicationDbContext> contextFactory = contextFactory;

    public async Task<IdentityResult> SignUp<TProfile>(
        TProfile model, 
        string email, 
        string role, 
        ApplicationUser user)
        where TProfile : class, IUserProfile
    {
        // Set values for ASP.NET database tables
        await UserManager.SetUserNameAsync(user, email);
        await UserManager.SetEmailAsync(user, email);
        var result = await UserManager.CreateAsync(user);
        if (!result.Succeeded)
        {
            return result;
        }
        var roleResult = await UserManager.AddToRoleAsync(user, role);
        if (!roleResult.Succeeded)
        {
            await UserManager.DeleteAsync(user);
            return roleResult;
        }

        try
        {
            // Store form data into non-ASP.NET tables
            using var context = contextFactory.CreateDbContext();
            model.Id = await UserManager.GetUserIdAsync(user);
            await context.AddAsync(model);
            await context.SaveChangesAsync();
            return IdentityResult.Success;
        }
        catch (System.Exception)
        {
            await UserManager.DeleteAsync(user);
            throw;
        }
    }
    public async Task<IdentityResult> ConfirmEmailWithCode(string code, ApplicationUser user)
    {
        var decodedCode = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
        var result = await UserManager.ConfirmEmailAsync(user, decodedCode);
        return result;
    }
    public async Task<bool> Confirm2FACode(string code, ApplicationUser user)
    {
        var verificationCode = code.Replace(" ", string.Empty).Replace("-", string.Empty);
        var is2faTokenValid = await UserManager.VerifyTwoFactorTokenAsync(user, UserManager.Options.Tokens.AuthenticatorTokenProvider, verificationCode);
        if (!is2faTokenValid) return false;
        await UserManager.SetTwoFactorEnabledAsync(user, true);
        return true;
    }
    public async Task<IdentityResult> SetPassword(string password, ApplicationUser user)
    {
        if (await IsPwnedAsync(password))
        {
            return IdentityResult.Failed(new IdentityError
            {
               Description = "Esta contraseña ha aparecido en filtraciones de datos. Te sugerimos utilizar tu Administrador de Contraseñas para obtener una contraseña segura y con caracteres aleatorios." 
            });
        }
        return await UserManager.AddPasswordAsync(user, password);
    }

    private async Task<int> GetPwnedCountAsync(string password)
    {
        var hash = Convert.ToHexString(
            SHA1.HashData(Encoding.UTF8.GetBytes(password)));

        var prefix = hash[..5];
        var suffix = hash[5..];

        using var request = new HttpRequestMessage(
            HttpMethod.Get,
            $"https://api.pwnedpasswords.com/range/{prefix}");

        request.Headers.UserAgent.ParseAdd("Neurosintergia");

        var response = await httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();

        var body = await response.Content.ReadAsStringAsync();

        foreach (var line in body.Split('\n'))
        {
            var parts = line.Trim().Split(':');

            if (parts.Length == 2 &&
                parts[0].Equals(suffix, StringComparison.OrdinalIgnoreCase) &&
                int.TryParse(parts[1], out var count))
            {
                return count;
            }
        }

        return 0;
    }
    private async Task<bool> IsPwnedAsync(string password)
    {
        return await GetPwnedCountAsync(password) > 0;
    }
}