using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
namespace friendly_broccoli.Models;

public class Global
{
    [AllowNull, EmailAddress(ErrorMessage = "El correo electrónico debe ser válido")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "El rol es requerido")]
    public required string Role { get; set; }
    [Required(ErrorMessage = "El identificador es requerido")]
    public required Guid Id { get; set; }
    public bool IsEmailVerified { get; set; } = false;
    public bool IsMFAEnabled { get; set; } = false;
    public bool IsBlocked { get; set; } = false;
}
