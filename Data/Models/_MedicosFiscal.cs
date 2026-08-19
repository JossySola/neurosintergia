using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace neurosintergia.Data.Models;

public class MedicosFiscal
{
    public required string Id { get; set; }
    public required string MedicoId { get; set; }
    public required string Email { get; set; }
    public string? Persona { get; set; }
    public string? RazonSocial { get; set; }
    public string? RFC { get; set; }
    public string? Regimen { get; set; }
    public string? Calle { get; set; }
    public int NumExt { get; set; }
    public string? NumInt { get; set; }
    public string? Colonia { get; set; }
    public int CodigoPostal { get; set; }
    public string? Municipio { get; set; }
    public string? Estado { get; set; }
}