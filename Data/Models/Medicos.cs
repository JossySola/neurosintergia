using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace neurosintergia.Data.Models;
public class Medicos
{
    [Required(ErrorMessage = "La fecha de creación es requerida")]
    public required DateTime Create_At { get; set; }
    [Required(ErrorMessage = "El identificador es requerido")]
    public required string Id { get; set; }
    [Required(ErrorMessage = "El nombre es requerido"), MinLength(3, ErrorMessage = "El nombre debe tener un mínimo de 3 caracteres")]
    public required string Nombre { get; set; }
    [Required(ErrorMessage = "El apellido paterno es requerido"), MinLength(3, ErrorMessage = "El apellido paterno debe tener un mínimo de 3 caracteres")]
    public required string ApellidoPaterno { get; set; }
    [AllowNull, MinLength(3, ErrorMessage = "El apellido materno debe tener un mínimo de 3 caracteres")]
    public string? ApellidoMaterno { get; set; }
    [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
    public required DateOnly FechaNacimiento { get; set; }
    [Required(ErrorMessage = "El número de teléfono es requerido"), StringLength(10, ErrorMessage = "El número de teléfono debe contener 10 dígitos"), Phone(ErrorMessage = "El número de teléfono tiene un formato inválido")]
    public required string Telefono { get; set; }
    [StringLength(10, ErrorMessage = "El número de teléfono debe contener 10 dígitos"), Phone(ErrorMessage = "El número de teléfono tiene un formato inválido"), AllowNull]
    public string? TelefonoUrgencias { get; set; }
    [Required(ErrorMessage = "El correo electrónico es requerido"), EmailAddress(ErrorMessage = "El correo electrónico es inválido")]
    public required string Email { get; set; }
    [Required(ErrorMessage = "La cédula profesional es requerida"), MinLength(7, ErrorMessage = "La cédula profesional debe tener un mínimo de 7 caracteres"), MaxLength(8, ErrorMessage = "La cédula profesional debe tener un máximo de 8 caracteres")]
    public required string CedProf { get; set; }
    [MinLength(7, ErrorMessage = "La cédula de especialidad debe tener un mínimo de 7 caracteres"), MaxLength(8, ErrorMessage = "La cédula de especialidad debe tener un máximo de 8 caracteres"), AllowNull]
    public string? CedEsp { get; set; }
    [MinLength(8, ErrorMessage = "El SSA debe tener un mínimo de 8 caracteres"), MaxLength(9, ErrorMessage = "El SSA debe tener un máximo de 9 caracteres"), AllowNull]
    public string? SSA { get; set; }
    [Required(ErrorMessage = "El título universitario es requerido")]
    public required string Titulo { get; set; }
    [Required(ErrorMessage = "El nombre del instituto es requerido")]
    public required string Instituto { get; set; }
    
}
