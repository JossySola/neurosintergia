using neurosintergia.Data;
using neurosintergia.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using neurosintergia.Components.Account.Pages;

namespace neurosintergia.Services;

public class CreationServices(
    IDbContextFactory<ApplicationDbContext> contextFactory,
    UserManager<ApplicationUser> userManager,
    ILogger<Register> logger)
{
    private readonly IDbContextFactory<ApplicationDbContext> ContextFactory = contextFactory;
    private readonly UserManager<ApplicationUser> UserManager = userManager;

    public async Task<IdentityResult> CrearAdmin(Admins model)
    {
        using var context = ContextFactory.CreateDbContext();

        var user = new ApplicationUser();
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
            model.Id = await UserManager.GetUserIdAsync(user);
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
