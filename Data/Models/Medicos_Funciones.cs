using System.ComponentModel.DataAnnotations;

namespace neurosintergia.Data.Models;

public class Medicos_Funciones
{
    [Key]
    public required string Id { get; set; }
    public required string MedicoId { get; set; }
    public bool Grupo_I { get; set; } = false;
    public bool Grupo_II { get; set; } = false;
    public bool Grupo_III { get; set; } = false;
    public bool Grupo_IV { get; set; } = false;
    public bool Grupo_V { get; set; } = false;
    public bool Grupo_VI { get; set; } = false;
}