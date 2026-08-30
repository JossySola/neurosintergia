using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using neurosintergia.Data;

namespace neurosintergia.Services;

public interface IUserProfile
{
    string Id { get; set; }
    string Email { get; set; }
}
public class AuthFlowService(
    UserManager<ApplicationUser> userManager,
    IDbContextFactory<ApplicationDbContext> contextFactory
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
    public async Task SetPassword(string password, ApplicationUser user)
    {
        await UserManager.AddPasswordAsync(user, password);
    }
}