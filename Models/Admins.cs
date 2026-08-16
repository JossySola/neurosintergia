using System.ComponentModel.DataAnnotations;

namespace friendly_broccoli.Models;
public class Admins
{
    [Required]
    public DateTime Created_At { get; set; }
    [Required]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "El nombre es requerido"), MinLength(3, ErrorMessage = "El nombre debe tener un mínimo de 3 caracteres")]
    public required string Nombre { get; set; }
    [Required(ErrorMessage = "El apellido paterno es requerido"), MinLength(3, ErrorMessage = "El apellido paterno debe tener un mínimo de 3 caracteres")]
    public required string ApellidoPaterno { get; set; }
    public string? ApellidoMaterno { get; set; }
    [Required(ErrorMessage = "El CURP es requerido"), Length(18,18, ErrorMessage = "El CURP debe tener 18 dígitos")]
    public required string CURP { get; set; }
    [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
    public DateOnly FechaNacimiento { get; set; }
    [Required(ErrorMessage = "La calle es requerida")]
    public required string Calle { get; set; }
    [Required(ErrorMessage = "El número exterior es requerido")]
    public required string NumExt { get; set; }
    public string? NumInt { get; set; }
    [Required(ErrorMessage = "La colonia es requerida")]
    public required string Colonia { get; set; }
    [Required(ErrorMessage = "El código postal es requerido")]
    public int CodigoPostal { get; set; }
    [Required(ErrorMessage = "El teléfono es requerido"), Phone(ErrorMessage = "Debes de ingresar un número de teléfono válido"), Length(10,10, ErrorMessage = "El número de teléfono debe ser de 10 dígitos")]
    public int Telefono { get; set; }
    [Required(ErrorMessage = "El correo electrónico es requerido"), EmailAddress(ErrorMessage = "El correo electrónico debe ser válido")]
    public required string Email { get; set; }
    [Required(ErrorMessage = "La contraseña es requerida"), MinLength(8, ErrorMessage = "La contraseña debe tener mínimo 8 caracteres")]
    public required string Passkey { get; set; }
    
}