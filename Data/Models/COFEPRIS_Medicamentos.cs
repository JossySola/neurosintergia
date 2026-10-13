namespace neurosintergia.Data.Models;

public class COFEPRIS_Medicamentos
{
    public int Id { get; set; }
    public string Medicamento { get; set; } = null!;
    public string Fraccion { get; set; } = null!;
    public string Dosis { get; set; } = null!;
    public string Presentaciones { get; set; } = null!;
    public string Rubro { get; set; } = null!;
}