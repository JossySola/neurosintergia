using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using friendly_broccoli.Models;

namespace friendly_broccoli.Data;

public class NeuroContext(DbContextOptions<NeuroContext> options) : DbContext(options)
{
    // Entities:
    public DbSet<Global> Global { get; set; } = default!;
    public DbSet<Admins> Admins { get; set; } = default!;
    public DbSet<Medicos> Medicos { get; set; } = default!;
    public DbSet<Pacientes> Pacientes { get; set; } = default!;
    public DbSet<MedicosFiscal> MedicosFiscal { get; set; } = default!;
    public DbSet<PacientesFiscal> PacientesFiscal { get; set; } = default!;
    public DbSet<Evoluciones> Evoluciones { get; set; } = default!;
    public DbSet<Exploraciones> Exploraciones { get; set; } = default!;
    public DbSet<IndicacionesTerapeuticas> IndicacionesTerapeuticas { get; set; } = default!;
    public DbSet<Interconsultas> Interconsultas { get; set; } = default!;
    public DbSet<InterrogatoriosIniciales> InterrogatoriosIniciales { get; set; } = default!;
    public DbSet<Recetas> Recetas { get; set; } = default!;
    public DbSet<Referencias> Referencias { get; set; } = default!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Define value comparer for List<Otros>
        var otrosComparer = new ValueComparer<List<Otros>>(
            (c1, c2) => JsonSerializer.Serialize(c1, (JsonSerializerOptions?)null) == JsonSerializer.Serialize(c2, (JsonSerializerOptions?)null),
            c => c == null ? 0 : JsonSerializer.Serialize(c, (JsonSerializerOptions?)null).GetHashCode(),
            c => JsonSerializer.Deserialize<List<Otros>>(JsonSerializer.Serialize(c, (JsonSerializerOptions?)null), (JsonSerializerOptions?)null) ?? new List<Otros>()
        );

        modelBuilder.Entity<InterrogatoriosIniciales>(entity =>
        {
            entity.Property(e => e.HF_Otros)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                    v => JsonSerializer.Deserialize<List<Otros>>(v, (JsonSerializerOptions?)null) ?? new List<Otros>())
                .Metadata.SetValueComparer(otrosComparer);

            entity.Property(e => e.PP_Otros)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                    v => JsonSerializer.Deserialize<List<Otros>>(v, (JsonSerializerOptions?)null) ?? new List<Otros>())
                .Metadata.SetValueComparer(otrosComparer);
        });
    }
}