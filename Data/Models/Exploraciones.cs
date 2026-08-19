using System.ComponentModel.DataAnnotations;

namespace neurosintergia.Data.Models;

public class Exploraciones
{
    [Required]
    public required Guid Id { get; set; }
    [Required]
    public required string PacienteId { get; set; }
    [Required]
    public required string MedicoId { get; set; }
    [Required]
    public required DateTime Create_At { get; set; }
    public string? HabitusExt { get; set; }
    public float? Temperatura { get; set; }
    public float? TensionArterial { get; set; }
    public int? FrecuenciaCardiaca { get; set; }
    public int? FrecuenciaRespiratoria { get; set; }
    public float? Peso { get; set; }
    public int? Talla { get; set; }
    public string? Aspecto { get; set; }
    public string? Apariencia { get; set; }
    public string? Conducta { get; set; }
    public string? Conciencia { get; set; }
    public string? Orientacion { get; set; }
    public string? Atencion { get; set; }
    public string? Memoria { get; set; }
    public  string? Lenguaje { get; set; }
    public string? Pensamiento { get; set; }
    public string? Juicio { get; set; }
    public string? Afecto { get; set; }
    public string? Autoconocimiento { get; set; }
}