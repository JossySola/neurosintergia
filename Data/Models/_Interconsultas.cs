namespace neurosintergia.Data.Models;

public class Interconsultas
{
    public required Guid Id { get; set; }
    public required string PacienteId { get; set; }
    public required string MedicoId { get; set; }
    public required DateTime Create_At { get; set; }
    public string? SignosVitales { get; set; }
    public string? MotivoAtencion { get; set; }
    public string? Interrogatorio { get; set; }
    public string? ResultadosEstudios { get; set; }
    public string? CriteriosDiagnosticos { get; set; }
    public string? PlanEstudios { get; set; }
    public string? SugerenciasDiagnosticas { get; set; }
    public string? Tratamiento { get; set; }
    public string? Pronostico { get; set; }
}