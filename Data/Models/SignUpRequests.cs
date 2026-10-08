using System.ComponentModel.DataAnnotations;

namespace neurosintergia.Data.Models;

public class SignUpRequests
{
    public required DateTime Created_At { get; set; }
    [Key]
    public required string Id { get; set; }
    public ApplicationUser User { get; set; } = default!;
    public string Status { get; set; } = "pending";
    public string? ReviewedBy { get; set; }
    public string? Comment { get; set; }
    public DateTime? LastReviewed { get; set; }
    public string? Token { get; set; }
    public DateTime? Token_Created_At { get; set; }
}

public sealed record PendingSignUpRow (
    string Id,
    DateTime Created_At,
    string Status,
    string? ReviewedBy,
    string? Comment,
    DateTime? LastReviewed,
    string Nombre,
    string ApellidoPaterno,
    string? ApellidoMaterno,
    DateOnly FechaNacimiento,
    string CURP,
    string MunicipioNacimiento,
    string EstadoNacimiento,
    string Email,
    List<Credenciales>? Credenciales
);