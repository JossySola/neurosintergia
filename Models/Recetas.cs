using System.ComponentModel.DataAnnotations;

namespace friendly_broccoli.Models;

public class Recetas
{
    [Required(ErrorMessage = "El identificador es requerido")]
    public required Guid Id { get; set; }
    [Required(ErrorMessage = "La fecha de creación es requerida")]
    public required DateTime Created_At { get; set; }
    [Required(ErrorMessage = "El identificador del médico es requerido")]
    public required Guid MedicoId { get; set; }
    [Required(ErrorMessage = "El identificador del paciente es requerido")]
    public required Guid PacienteId { get; set; }
    [Required(ErrorMessage = "El medicamento es requerido")]
    public required string Medicamento { get; set; }
    [Required(ErrorMessage = "La dosis es requerida")]
    public required string Dosis { get; set; }
    [Required(ErrorMessage = "La presentación es requerida")]
    public required string Presentacion { get; set; }
    [Required(ErrorMessage = "La cantidad es requerida")]
    public int Cantidad { get; set; } = 1;
    [Required(ErrorMessage = "La frecuencia es requerida")]
    public int Frecuencia { get; set; } = 1;
    [Required(ErrorMessage = "El periodo de tiempo es requerido")]
    public int PeriodoTiempo { get; set; } = 1;
    [Required(ErrorMessage = "La indicación de suspensión es requerida")]
    public bool SinSuspender { get; set; } = false;
    public string? Nota { get; set; }
}
