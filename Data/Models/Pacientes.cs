using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace neurosintergia.Data.Models;
public class Pacientes
{
    [Required(ErrorMessage = "La fecha de creación es requerida")]
    public required DateTime Created_At { get; set; }
    [Required(ErrorMessage = "El identificador es requerido")]
    public required string Id { get; set; }
    [Required(ErrorMessage = "El nombre es requerido"), MinLength(3, ErrorMessage = "El nombre debe tener un mínimo de 3 caracteres")]
    public required string Nombre { get; set; }
    [Required(ErrorMessage = "El apellido paterno es requerido"), MinLength(3, ErrorMessage = "El apellido paterno debe tener un mínimo de 3 caracteres")]
    public required string ApellidoPaterno { get; set; }
    [MinLength(3, ErrorMessage = "El apellido materno debe tener un mínimo de 3 caracteres"), AllowNull]
    public string? ApellidoMaterno { get; set; }
    [Required(ErrorMessage = "El CURP es requerido"), Length(18, 18, ErrorMessage = "El CURP debe tener 18 dígitos")]
    public required string CURP { get; set; }
    [Required(ErrorMessage = "El lugar de nacimiento es requerido")]
    public required string LugarNacimiento { get; set; }
    [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
    public DateOnly FechaNacimiento { get; set; }
    [Required(ErrorMessage = "El sexo es requerido")]
    public required string Sexo { get; set; }
    [Required(ErrorMessage = "La calle es requerida")]
    public required string Calle { get; set; }
    [Required(ErrorMessage = "El número exterior es requerido")]
    public required string NumExt { get; set; }
    [AllowNull]
    public string? NumInt { get; set; }
    [Required(ErrorMessage = "La colonia es requerida")]
    public required string Colonia { get; set; }
    [Required(ErrorMessage = "El código postal es requerido")]
    public required string CodigoPostal { get; set; }
    [Required(ErrorMessage = "El teléfono es requerido"), Length(10, 10, ErrorMessage = "El número de teléfono debe ser de 10 dígitos"), Phone(ErrorMessage = "Debes de ingresar un número de teléfono válido")]
    public required string Telefono { get; set; }
    [Length(10, 10, ErrorMessage = "El número de celular debe ser de 10 dígitos"), Phone(ErrorMessage = "Debes de ingresar un número de celular válido"), AllowNull]
    public string? Celular {get; set; }
    [EmailAddress(ErrorMessage = "El correo electrónico debe ser válido"), AllowNull]
    public string? Email { get; set; }
    [Required(ErrorMessage = "El contacto de emergencia es requerido"), MinLength(3, ErrorMessage = "El contacto de emergencia debe tener un mínimo de 3 caracteres")]
    public required string ContactoEmergenciaI { get; set; }
    [Required(ErrorMessage = "El teléfono de emergencia es requerido"), Phone(ErrorMessage = "Debes de ingresar un número de teléfono de emergencia válido"), Length(10, 10, ErrorMessage = "El número de teléfono de emergencia debe ser de 10 dígitos")]
    public required string TelefonoEmergenciaI { get; set; }
    [MinLength(3, ErrorMessage = "El contacto de emergencia debe tener un mínimo de 3 caracteres"), AllowNull]
    public string? ContactoEmergenciaII { get; set; }
    [Length(10, 10, ErrorMessage = "El número de teléfono de emergencia debe ser de 10 dígitos"), Phone(ErrorMessage = "Debes de ingresar un número de teléfono de emergencia válido"), AllowNull]
    public string? TelefonoEmergenciaII { get; set; }
}
