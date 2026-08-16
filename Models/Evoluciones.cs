using System.ComponentModel.DataAnnotations;

namespace friendly_broccoli.Models;

public class Evoluciones
{
    [Required]
    public required Guid Id { get; set; }
    [Required]
    public required Guid PacienteId { get; set; }
    [Required]
    public required Guid MedicoId { get; set; }
    [Required]
    public required DateTime Create_At { get; set; }
    public string? CuadroClinico { get; set; }
    public string? SignosVitales { get; set; }
    public string? ResultadosEstudios { get; set; }
    public string? Diagnosticos { get; set; }
    public string? ProblemasClinicos { get; set; }
    public string? Pronostico { get; set; }
    public string? Subjetivo { get; set; }
    public string? Objetivo { get; set; }
    public string? Analisis { get; set; }
    public string? PlanTratamiento { get; set; }
}