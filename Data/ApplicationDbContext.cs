using neurosintergia.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Text.Json;

namespace neurosintergia.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Admins> Admins { get; set; } = default!;
    public DbSet<Medicos> Medicos { get; set; } = default!;
    public DbSet<Pacientes> Pacientes { get; set; } = default!;
    public DbSet<SignUpRequests> SignUpRequests { get; set; } = default!;
    public DbSet<Recetas> Recetas { get; set; } = default!;
    public DbSet<InterrogatoriosIniciales> InterrogatoriosIniciales { get; set; } = default!;
    public DbSet<Evoluciones> Evoluciones { get; set; } = default!;
    public DbSet<Exploraciones> Exploraciones { get; set; } = default!;
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<SignUpRequests>()
        .HasOne(a => a.User)
        .WithOne()
        .HasForeignKey<SignUpRequests>(a => a.Id)
        .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Admins>()
        .HasOne(a => a.User)
        .WithOne()
        .HasForeignKey<Admins>(a => a.Id)
        .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Medicos>()
        .HasOne(m => m.User)
        .WithOne()
        .HasForeignKey<Medicos>(m => m.Id)
        .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Pacientes>()
        .HasOne(p => p.User)
        .WithOne()
        .HasForeignKey<Pacientes>(p => p.Id)
        .OnDelete(DeleteBehavior.Cascade);

        var otrosComparer = new ValueComparer<List<Otros>>(
            (a, b) => JsonSerializer.Serialize(a, (JsonSerializerOptions?)null)
                == JsonSerializer.Serialize(b, (JsonSerializerOptions?)null),
            v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null).GetHashCode(),
            v => JsonSerializer.Deserialize<List<Otros>>(
                JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                (JsonSerializerOptions?)null) ?? new()
        );
        builder.Entity<InterrogatoriosIniciales>(entity =>
        {
            entity.Property(e => e.HF_Otros)
            .HasConversion(
                v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                v => JsonSerializer.Deserialize<List<Otros>>(v, (JsonSerializerOptions?)null) ?? new()
            )
            .Metadata.SetValueComparer(otrosComparer);

            entity.Property(e => e.PP_Otros)
            .HasConversion(
                v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                v => JsonSerializer.Deserialize<List<Otros>>(v, (JsonSerializerOptions?)null) ?? new()
            )
            .Metadata.SetValueComparer(otrosComparer);

            entity.Property(e => e.PNP_Otros)
            .HasConversion(
                v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                v => JsonSerializer.Deserialize<List<Otros>>(v, (JsonSerializerOptions?)null) ?? new()
            )
            .Metadata.SetValueComparer(otrosComparer);
        });
    }
}
