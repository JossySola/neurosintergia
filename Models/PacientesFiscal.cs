using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace friendly_broccoli.Models;

public class PacientesFiscal
{
    public required int Id { get; set; }
    public required Guid PacienteId { get; set; }
    public required string Email { get; set; }
    public string? RFC { get; set; }
    public string? RazonSocial { get; set; }
    public string? Regimen { get; set; }
    public string? UsoCFDI { get; set; }
    public string? Calle { get; set; }
    public int NumExt { get; set; }
    public string? NumInt { get; set; }
    public string? Colonia { get; set; }
    public int CodigoPostal { get; set; }
    public string? Municipio { get; set; }
    public string? Estado { get; set; }
}