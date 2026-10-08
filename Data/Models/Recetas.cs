using System.ComponentModel.DataAnnotations;

namespace neurosintergia.Data.Models;

public class Recetas
{
    [Key]
    public required Guid Id { get; set; }
    public required string MedicoId { get; set; }
    public required string PacienteId { get; set; }
    public required DateTime Created_At { get; set; }
    public required string Medicamento { get; set; }
    public required string Dosis { get; set; }
    public required string Presentacion { get; set; }
    public int Cantidad { get; set; } = 1;
    public int Frecuencia { get; set; } = 1;
    public int PeriodoTiempo { get; set; } = 1;
    public bool SinSuspender { get; set; } = false;
    public string? Nota { get; set; }
}