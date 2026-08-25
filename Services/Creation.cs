using neurosintergia.Data;
using neurosintergia.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace neurosintergia.Services;

public class CreationServices(
    IDbContextFactory<ApplicationDbContext> contextFactory,
    UserManager<ApplicationUser> userManager)
{
    private readonly IDbContextFactory<ApplicationDbContext> ContextFactory = contextFactory;
    private readonly UserManager<ApplicationUser> UserManager = userManager;

    public async Task<IdentityResult> CrearAdmin(Admins model, ApplicationUser user)
    {
        using var context = ContextFactory.CreateDbContext();
        
        await UserManager.SetUserNameAsync(user, model.Email);
        await UserManager.SetEmailAsync(user, model.Email);

        var result = await UserManager.CreateAsync(user);
        if (!result.Succeeded)
        {
            return result;
        }

        var roleResult = await UserManager.AddToRoleAsync(user, "Admin");
        if (!roleResult.Succeeded)
        {
            await UserManager.DeleteAsync(user);
            return roleResult;
        }

        try
        {
            var userId = await UserManager.GetUserIdAsync(user);
            model.Id = userId;
            await context.AddAsync(model);
            await context.SaveChangesAsync();

            return IdentityResult.Success;
        }
        catch
        {
            await UserManager.DeleteAsync(user);
            throw;
        }
    }
}
