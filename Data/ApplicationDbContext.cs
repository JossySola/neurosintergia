using neurosintergia.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace neurosintergia.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Admins> Admins { get; set; } = default!;
    public DbSet<Medicos> Medicos { get; set; } = default!;
    public DbSet<Pacientes> Pacientes { get; set; } = default!;
    public DbSet<Recetas> Recetas { get; set; } = default!;
    public DbSet<InterrogatoriosIniciales> InterrogatoriosIniciales { get; set; } = default!;
    public DbSet<Evoluciones> Evoluciones { get; set; } = default!;
    public DbSet<Exploraciones> Exploraciones { get; set; } = default!;
}
