using System.ComponentModel.DataAnnotations;
using neurosintergia.Services;

namespace neurosintergia.Data.Models;

public record Credenciales(
    string Id,
    string Instituto, 
    string Titulo, 
    string CedProf, 
    string CedEsp, 
    string SSA
);
public class Medicos : IUserProfile
{
    public required DateTime Create_At { get; set; }
    [Key]
    public required string Id { get; set; }
    public ApplicationUser User { get; set; } = default!;
    public required string Nombre { get; set; }
    public required string ApellidoPaterno { get; set; }
    public string? ApellidoMaterno { get; set; }
    public required DateOnly FechaNacimiento { get; set; }
    public required string CURP { get; set; }
    public required string Telefono { get; set; }
    public string? TelefonoUrgencias { get; set; }
    public required string Email { get; set; }
    public List<Credenciales>? Credenciales { get; set; }
}
