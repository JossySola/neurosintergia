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
    public DbSet<Medicos_Funciones> Medicos_Funciones { get; set; } = default!;
    public DbSet<COFEPRIS_Medicamentos> COFEPRIS_Medicamentos { get; set; } = default!;
 
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Recetas>()
        .Property(r => r.Tratamiento)
        .HasConversion(
            value => JsonSerializer.Serialize(value, (JsonSerializerOptions?)null),
            value => JsonSerializer.Deserialize<List<Tratamiento>>(
                value, (JsonSerializerOptions?)null) ?? new()
        )
        .Metadata.SetValueComparer(
            new ValueComparer<List<Tratamiento>>(
                (left, right) => JsonSerializer.Serialize(left, (JsonSerializerOptions?)null)
                == JsonSerializer.Serialize(right, (JsonSerializerOptions?)null),
                value => JsonSerializer.Serialize(value, (JsonSerializerOptions?)null).GetHashCode(),
                value => JsonSerializer.Deserialize<List<Tratamiento>>(
                    JsonSerializer.Serialize(value, (JsonSerializerOptions?)null),
                    (JsonSerializerOptions?)null) ?? new()
            )
        );

        builder.Entity<COFEPRIS_Medicamentos>()
        .ToTable("COFEPRIS_Medicamentos", table => table.ExcludeFromMigrations());

        builder.Entity<SignUpRequests>()
        .HasOne(a => a.User)
        .WithOne()
        .HasForeignKey<SignUpRequests>(a => a.Id)
        .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Medicos_Funciones>()
        .HasOne<Medicos>()
        .WithOne()
        .HasForeignKey<Medicos_Funciones>(f => f.MedicoId)
        .HasPrincipalKey<Medicos>(m => m.Id)
        .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Recetas>()
        .HasOne<Medicos>()
        .WithMany()
        .HasForeignKey(r => r.MedicoId)
        .HasPrincipalKey(m => m.Id)
        .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Recetas>()
        .HasOne<Pacientes>()
        .WithMany()
        .HasForeignKey(r => r.PacienteId)
        .HasPrincipalKey(p => p.Id)
        .OnDelete(DeleteBehavior.Restrict);

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

        builder.Entity<Medicos>()
        .HasMany(m => m.Credenciales)
        .WithOne()
        .HasForeignKey("MedicosId")
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

        var pacienteOtrosComparer = new ValueComparer<List<PacienteOtro>>(
            (a, b) => JsonSerializer.Serialize(a, (JsonSerializerOptions?)null)
                == JsonSerializer.Serialize(b, (JsonSerializerOptions?)null),
            v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null).GetHashCode(),
            v => JsonSerializer.Deserialize<List<PacienteOtro>>(
                JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                (JsonSerializerOptions?)null) ?? new()
        );

        builder.Entity<Pacientes>(entity =>
        {
            entity.Property(p => p.HF_Otros)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                    v => JsonSerializer.Deserialize<List<PacienteOtro>>(v, (JsonSerializerOptions?)null) ?? new())
                .Metadata.SetValueComparer(pacienteOtrosComparer);

            entity.Property(p => p.PP_Otros)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                    v => JsonSerializer.Deserialize<List<PacienteOtro>>(v, (JsonSerializerOptions?)null) ?? new())
                .Metadata.SetValueComparer(pacienteOtrosComparer);

            entity.Property(p => p.PNP_Otros)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                    v => JsonSerializer.Deserialize<List<PacienteOtro>>(v, (JsonSerializerOptions?)null) ?? new())
                .Metadata.SetValueComparer(pacienteOtrosComparer);
        });
    }
}
