namespace friendly_broccoli.Models;

public class Referencias
{
    public required Guid Id { get; set; }
    public required Guid PacienteId { get; set; }
    public required Guid MedicoId { get; set; }
    public required DateTime Create_At { get; set; }
    public required string Envia { get; set; }
    public required string Recibe { get; set; }
    public required string MotivoEnvio { get; set; }
    public required string ImpresionDiagnostica { get; set; }
    public required string TerapeuticaEmpleada { get; set; }
}