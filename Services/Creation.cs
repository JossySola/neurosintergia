using neurosintergia.Data;
using neurosintergia.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace neurosintergia.Services;

public class CreationServices(
    IDbContextFactory<ApplicationDbContext> contextFactory,
    UserManager<ApplicationUser> userManager)
{
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory = contextFactory;
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    public async Task<bool> CrearMedico(Medicos model)
    {
        var user = await CreateUserAsync(model.Email, "Medico");
        if (user is null)
        {
            return false;
        }

        model.Id = user.Id;
        using var context = _contextFactory.CreateDbContext();
        try
        {
            await context.AddAsync(model);
            await context.SaveChangesAsync();
            return true;
        }
        catch
        {
            await _userManager.DeleteAsync(user);
            throw;
        }
    }

    public async Task<bool> CrearPaciente(Pacientes model)
    {
        ApplicationUser? user = null;
        if (!string.IsNullOrWhiteSpace(model.Email))
        {
            user = await CreateUserAsync(model.Email, "Paciente");
            if (user is null)
            {
                return false;
            }

            model.Id = user.Id;
        }

        using var context = _contextFactory.CreateDbContext();
        try
        {
            await context.AddAsync(model);
            await context.SaveChangesAsync();
            return true;
        }
        catch
        {
            if (user is not null)
            {
                await _userManager.DeleteAsync(user);
            }

            throw;
        }
    }

    public async Task<bool> CrearReceta(Recetas model)
    {
        using var context = _contextFactory.CreateDbContext();
        await context.AddAsync(model);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> CrearEvolucion(Evoluciones model)
    {
        using var context = _contextFactory.CreateDbContext();
        await context.AddAsync(model);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> CrearInterrogatorio(InterrogatoriosIniciales model)
    {
        using var context = _contextFactory.CreateDbContext();
        await context.AddAsync(model);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> CrearExploracion(Exploraciones model)
    {
        using var context = _contextFactory.CreateDbContext();
        await context.AddAsync(model);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> CrearAdmin(Admins model)
    {
        var user = new ApplicationUser
        {
            Email = model.Email,
            UserName = model.Email,
            Role = "Admin"
        };

        model.Id = user.Id;
        using var context = _contextFactory.CreateDbContext();
        try
        {
            await context.AddAsync(model);
            await context.SaveChangesAsync();
            return true;
        }
        catch
        {
            await _userManager.DeleteAsync(user);
            throw;
        }
    }

    private async Task<ApplicationUser?> CreateUserAsync(string email, string role)
    {
        var user = new ApplicationUser
        {
            Email = email,
            UserName = email,
            Role = role
        };
        var result = await _userManager.CreateAsync(user);
        return result.Succeeded ? user : null;
    }
}
