using System.ComponentModel.DataAnnotations;

namespace neurosintergia.Data.Models;

public record Tratamiento(
    string Medicamento,
    string Dosis,
    string Presentacion,
    string Cantidad,
    string Frecuencia,
    string Periodo,
    bool SinSuspender
);
public class Recetas
{
    [Key]
    public required Guid Id { get; set; }
    public required string MedicoId { get; set; }
    public required string PacienteId { get; set; }
    public required DateTime Created_At { get; set; }
    public required List<Tratamiento> Tratamiento { get; set; }
    public string? Nota { get; set; }
}