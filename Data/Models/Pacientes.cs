using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace neurosintergia.Data.Models;

public class Pacientes
{
    public required DateTime Created_At { get; set; }
    [Key]
    public required string Id { get; set; }
    public ApplicationUser User { get; set; } = default!;
    public required string Nombre { get; set; }
    public required string ApellidoPaterno { get; set; }
    public string? ApellidoMaterno { get; set; }
    public required string CURP { get; set; }
    public required string Sexo { get; set; }
    public required string EstadoNacimiento { get; set; }
    public required string MunicipioNacimiento { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public required string Calle { get; set; }
    public required string NumExt { get; set; }
    public string? NumInt { get; set; }
    public required string Colonia { get; set; }
    public required string CodigoPostal { get; set; }
    public required string Estado { get; set; }
    public required string Municipio { get; set; }
    public required string Telefono { get; set; }
    public string? TelefonoCelular { get; set; }
    public string? Email { get; set; }
    public required string ContactoEmergenciaI { get; set; }
    public required string TelefonoEmergenciaI { get; set; }
    public string? ContactoEmergenciaII { get; set; }
    public string? TelefonoEmergenciaII { get; set; }

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
    public List<PacienteOtro> HF_Otros { get; set; } = [];

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
    public List<PacienteOtro> PP_Otros { get; set; } = [];

    public bool PNP_Alcohol { get; set; }
    public bool PNP_Tabaco { get; set; }
    public bool PNP_Cafeina { get; set; }
    public bool PNP_Sustancias { get; set; }
    public List<PacienteOtro> PNP_Otros { get; set; } = [];

    public string? Padecimiento { get; set; }
    public string? Tratamiento { get; set; }
    public string? Resumen { get; set; }
    public string? Notas { get; set; }

    // Compatibility aliases for the older patient registration form.
    [NotMapped]
    public string LugarNacimiento { get => EstadoNacimiento; set => EstadoNacimiento = value; }

    [NotMapped]
    public string? Celular { get => TelefonoCelular; set => TelefonoCelular = value; }
}

public sealed class PacienteOtro
{
    public string Opcion { get; set; } = "";
    public string Valor { get; set; } = "";
}
