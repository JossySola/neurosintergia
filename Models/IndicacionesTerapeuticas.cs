namespace friendly_broccoli.Models;

public class IndicacionesTerapeuticas
{
    public required Guid Id { get; set; }
    public required Guid PacienteId { get; set; }
    public required Guid MedicoId { get; set; }
    public required DateTime Create_At { get; set; }
    public required string Indicaciones { get; set; }
    public string? Notas { get; set; }
}