using System.ComponentModel.DataAnnotations;

namespace friendly_broccoli.Models;

public record Otros(Guid Id, string Opcion, bool Valor);
public class InterrogatoriosIniciales
{
    [Required]
    public required Guid Id { get; set; }
    [Required]
    public required Guid PacienteId { get; set; }
    [Required]
    public required Guid MedicoId { get; set; }
    [Required]
    public required DateTime Create_At { get; set; }
    public string? HabitaEn { get; set; }
    public string? ViveCon { get; set; }
    public string? Profesion { get; set; }
    public string? GrupoEtnico { get; set; }
    public bool HF_Diabetes { get; set; }
    public bool HF_Hipertension { get; set; }
    public bool HF_Artritis { get; set; }
    public bool HF_DoloresCabeza { get; set; }
    public bool HF_Epilepsia { get; set; }
    public bool HF_Alcohol { get; set; }
    public bool HF_Drogadiccion { get; set; }
    public bool HF_Tiroides { get; set; }
    public bool HF_Alzheimer { get; set; }
    public bool HF_Depresion { get; set; }
    public bool HF_Ansiedad { get; set; }
    public bool HF_Demencia { get; set; }
    public bool HF_Cancer { get; set; }
    public bool HF_Corazon { get; set; }
    public bool HF_Higado { get; set; }
    public bool HF_Rinon { get; set; }
    public bool HF_Anemia { get; set; }
    public bool HF_Gastritis { get; set; }
    public List<Otros> HF_Otros { get; set; } = [];
    public bool PP_Diabetes { get; set; }
    public bool PP_Hipertension { get; set; }
    public bool PP_Artritis { get; set; }
    public bool PP_DoloresCabeza { get; set; }
    public bool PP_Epilepsia { get; set; }
    public bool PP_Alcohol { get; set; }
    public bool PP_Drogadiccion { get; set; }
    public bool PP_Tiroides { get; set; }
    public bool PP_Alzheimer { get; set; }
    public bool PP_Depresion { get; set; }
    public bool PP_Ansiedad { get; set; }
    public bool PP_Demencia { get; set; }
    public bool PP_Cancer { get; set; }
    public bool PP_Corazon { get; set; }
    public bool PP_Higado { get; set; }
    public bool PP_Rinon { get; set; }
    public bool PP_Anemia { get; set; }
    public bool PP_Gastritis { get; set; }
    public bool PP_VIH { get; set; }
    public List<Otros> PP_Otros { get; set; } = [];
    public bool PNP_Alcohol { get; set; }
    public bool PNP_Tabaco { get; set; }
    public bool PNP_Cafeina { get; set; }
    public bool PNP_Sustancias { get; set; }
    public List<Otros> PNP_Otros { get; set; } = [];
    public string Padecimiento { get; set; } = "";
    public string Tratamiento { get; set; } = "";
    public string Resumen { get; set; } = "";
    public string Notas { get; set; } = "";
}