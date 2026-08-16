using friendly_broccoli.Data;
using friendly_broccoli.Models;
using Microsoft.EntityFrameworkCore;

namespace friendly_broccoli.Services;

public class CreationServices(IDbContextFactory<NeuroContext> contextFactory)
{
    private readonly IDbContextFactory<NeuroContext> _contextFactory = contextFactory;
    public async Task<bool> CrearMedico(Medicos model)
    {
        using var context = _contextFactory.CreateDbContext();
        Global GlobalInstance = new()
        {
            Email = model.Email,
            Role = "Medico",
            Id = model.Id,
        };
        try
        {
            await context.AddAsync(model);
            await context.AddAsync(GlobalInstance);
            await context.SaveChangesAsync();
            return true;
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
    public async Task<bool> CrearPaciente(Pacientes model)
    {
        using var context = _contextFactory.CreateDbContext();
        Global GlobalInstance = new()
        {
            Email = model.Email ?? "",
            Role = "Paciente",
            Id = model.Id,
        };
        try
        {
            await context.AddAsync(model);
            await context.AddAsync(GlobalInstance);
            await context.SaveChangesAsync();
            return true;
        }
        catch (System.Exception)
        {
            throw;
        }
    }
    public async Task<bool> CrearReceta(Recetas model)
    {
        using var context = _contextFactory.CreateDbContext();
        try
        {
            await context.AddAsync(model);
            await context.SaveChangesAsync();
            return true;
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
    public async Task<bool> CrearEvolucion(Evoluciones model)
    {
        using var context = _contextFactory.CreateDbContext();
        try
        {
            await context.AddAsync(model);
            await context.SaveChangesAsync();
            return true;
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
    public async Task<bool> CrearInterrogatorio(InterrogatoriosIniciales model)
    {
        using var context = _contextFactory.CreateDbContext();
        try
        {
            await context.AddAsync(model);
            await context.SaveChangesAsync();
            return true;
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
    public async Task<bool> CrearExploracion(Exploraciones model)
    {
        using var context = _contextFactory.CreateDbContext();
        try
        {
            await context.AddAsync(model);
            await context.SaveChangesAsync();
            return true;
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
    public async Task<bool> CrearAdmin(Admins model)
    {
        using var context = _contextFactory.CreateDbContext();
        Global GlobalInstance = new()
        {
            Email = model.Email,
            Role = "Admin",
            Id = model.Id,
        };
        try
        {
            await context.AddAsync(model);
            await context.AddAsync(GlobalInstance);
            await context.SaveChangesAsync();
            return true;
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}