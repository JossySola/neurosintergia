namespace friendly_broccoli.Data.Static;

// This would be static data from a database
public record Medicamento(string Nombre, string[] Dosis);
public record CategoriaMedicamento(string Categoria, List<Medicamento> Medicamentos);

public class COFEPRIS
{
    public List<CategoriaMedicamento> Grupo_I { get; } = 
    [
        new CategoriaMedicamento("Estupefacientes",
        [
            new("Buprenorfina", ["0.2 mg", "2 mg", "8 mg", "0.3 mg/ml", "5 mcg/h", "10 mcg/h", "20 mcg/h"])
        ])
    ];
    public List<CategoriaMedicamento> Grupo_II { get; } =
    [
        new CategoriaMedicamento("Psicotropicos",
        [
          new("Metilfenidato", ["10 mg", "18 mg", "27 mg", "36 mg", "54 mg", "20 mg", "30 mg", "40 mg"]),
          new("Lisdexanfetamina", ["20 mg", "30 mg", "50 mg", "70 mg"])
        ])  
    ];
    public List<CategoriaMedicamento> Grupo_III { get; } =
    [
        new CategoriaMedicamento("BZD",
        // Ansiolíticos e Hipnóticos, Benzodiacepinas
        [
            new("Clonazepam", ["0.5 mg", "1 mg", "2 mg", "2.5 mg/ml", "1 mg/ml"]),
            new("Alprazolam", ["0.25 mg", "0.5 mg", "1 mg", "2 mg"]),
            new("Lorazepam", ["1 mg", "2 mg", "2 mg/ml", "4 mg/ml"]),
            new("Diazepam", ["5 mg", "10 mg", "10 mg/2 ml"]),
            new("Bromazepam", ["1.5 mg", "3 mg", "6 mg"]),
            new("Clobazam", ["10 mg", "20 mg"]),
        ]),
        new CategoriaMedicamento("Hipnóticos",
        // Fármacos Z y No Benzodiacepínicos
        [
            new("Zolpidem", ["5 mg", "10 mg", "6.25 mg", "12.5 mg"]),
            new("Zopiclona", ["7.5 mg"]),
            new("Eszopiclona", ["1 mg", "2 mg", "3 mg"]),
            new("Buspirona", ["5 mg", "10 mg"]),
        ]),
    ];
    public List<CategoriaMedicamento> Grupo_IV { get; } =
    [
        new CategoriaMedicamento("ISRS",
        [
            new("Sertralina", ["50 mg", "100 mg", "20 mg/ml"]),
            new("Fluoxetina", ["20 mg", "20 mg/5 ml"]),
            new("Escitalopram", ["10 mg", "20 mg", "10 mg/ml", "20 mg/ml"]),
            new("Citalopram", ["20 mg", "40 mg", "40 mg/ml"]),
            new("Paroxetina", ["10 mg", "20 mg", "30 mg", "40 mg"]),
            new("Fluvoxamina", ["50 mg", "100 mg"]),
        ]),
        new CategoriaMedicamento("ISRN", 
        // Inhibidores de la Recaptación de Serotonina y Noradrenalina
        [
            new("Venlafaxina", ["37.5 mg", "75 mg", "150 mg"]),
            new("Duloxetina", ["30 mg", "60 mg"]),
            new("Desvenlafaxina", ["50 mg", "100 mg"]),
            new("Milnaciprán", ["25 mg", "50 mg"])
        ]),
        new CategoriaMedicamento("Atipicos",
        // Atípicos y Multimodales
        [
            new("Bupropión", ["150 mg", "300 mg"]),
            new("Mirtazapina", ["15 mg", "30 mg", "45 mg"]),
            new("Vortioxetina", ["5 mg", "10 mg", "15 mg", "20 mg", "20 mg/ml"]),
            new("Trazodona", ["50 mg", "100 mg", "150 mg"]),
            new("Agomelatina", ["25 mg"]),
            new("Mianserina", ["30 mg", "60 mg"]),
            new("Tianeptina", ["12.5 mg"])
        ]),
        new CategoriaMedicamento("Triciclicos", 
        [
            new("Amitriptilina", ["25 mg", "50 mg", "75 mg"]),
            new("Clomipramina", ["25 mg, 75 mg"]),
            new("Imipramina", ["10 mg", "25 mg", "50 mg"]),
        ]),
        new CategoriaMedicamento("Antipsicoticos",
        // Antipsicóticos / Neurolépticos, Segunda Generación / Atípicos (SGA)
        [
            new("Quetiapina", ["25 mg", "100 mg", "200 mg", "300 mg", "400 mg"]),
            new("Risperidona", ["1 mg", "2 mg", "3 mg", "4 mg", "1 mg/ml", "25 mg", "37.5 mg", "50 mg"]),
            new("Olanzapina", ["2.5 mg", "5 mg", "7.5 mg", "10 mg", "15 mg", "20 mg"]),
            new("Aripiprazol", ["5 mg", "10 mg", "15 mg", "30 mg", "1 mg/ml", "400 mg"]),
            new("Clozapina", ["25 mg", "100 mg"]),
            new("Paliperidona", ["3 mg", "6 mg", "9 mg", "75 mg", "100 mg", "150 mg"]),
            new("Lurasidona", ["20 mg", "40 mg", "80 mg"]),
            new("Brexpiprazol", ["0.5 mg", "1 mg", "2 mg", "3 mg", "4 mg"]),
        ]),
        new CategoriaMedicamento("Tipicos",
        // Primera Generación / Típicos
        [
            new("Haloperidol", ["5 mg", "10 mg", "2 mg/ml", "5 mg/ml", "50 mg/ml"]),
            new("Levomepromazina", ["25 mg", "100 mg", "40 mg/ml (gotas 4%)", "25 mg/1 ml"]),
            new("Sulpirida", ["50 mg", "200 mg", "50 mg/5 ml"]),
            new("Zuclopentixol", ["10 mg", "25 mg", "50 mg/ml", "200 mg/ml"]),
        ]),
        new CategoriaMedicamento("Estabilizadores",
        // Estabilizadores del Estado de Ánimo
        [
            new("Carbonato de Litio", ["300 mg", "400 mg"]),
            new("Valproato de Magnesio/Ácido Valproico", ["200 mg", "250 mg", "500 mg", "200 mg/ml"]),
            new("Lamotrigina", ["25 mg", "50 mg", "100 mg", "200 mg"]),
            new("Carbamazepina", ["200 mg", "400 mg", "100 mg/5 ml"]),
            new("Oxcarbazepina", ["300 mg", "600 mg", "60 mg/ml"]),
        ]),
        new CategoriaMedicamento("Gabapentinoides",
        // Gabapentinoides y Ansioliticos No Benzodiacepinicos
        [
            new("Gabapentina", ["300 mg", "400 mg", "600 mg", "800 mg"]),
            new("Pregabalina", ["75 mg", "150 mg", "300 mg"]),
            new("Buspirona", ["5 mg", "10 mg"]),
            new("Hidroxizina", ["10 mg", "25 mg", "2 mg/ml"]),
            new("Propranolol", ["10 mg", "40 mg", "80 mg"]),
            new("Clonidina", ["0.1 mg", "0.15 mg"]),
        ]),
        new CategoriaMedicamento("Vigilia",
        // No Estimulantes y Promotores de Vigilia
        [
            new("Atomoxetina", ["10 mg", "18 mg", "25 mg", "40 mg", "60 mg", "80 mg", "100 mg"]),
            new("Modafinilo", ["100 mg", "200 mg"]),
            new("Armodafinilo", ["50 mg", "150 mg", "250 mg"]),
            new("Pitolisant", ["4.5 mg", "18 mg"]),
        ]),
        new CategoriaMedicamento("Regulacion",
        [
            new("Ramelteón", ["8 mg"]),
        ]),
        new CategoriaMedicamento("Antidemenciales",
        // Antidemenciales / Deterioro Cognitivo
        [
            new("Donepezilo", ["5 mg", "10 mg"]),
            new("Rivastigmina", ["1.5 mg", "3 mg", "4.5 mg", "6 mg", "2 mg/ml", "4.6 mg/24h", "9.5 mg/24h", "13.3 mg/24h"]),
            new("Galantamina", ["8 mg", "16 mg", "24 mg", "4 mg/ml"]),
            new("Memantina", ["10 mg", "20 mg", "10 mg/g", "10 mg/ml"]),
        ]),
        new CategoriaMedicamento("Moduladores",
        // Moduladores de Impulsos y Adicciones
        [
            new("Naltrexona", ["50 mg", "380 mg"]),
            new("Acamprosato", ["333 mg"]),
            new("Disulfiram", ["250 mg", "500 mg"]),
        ]),
    ];
    public List<CategoriaMedicamento> Grupo_V { get; } =
    [
      new CategoriaMedicamento("Cronobiologico",
      [
          new("Melatonina", ["2 mg", "3 mg", "5 mg"])
      ])  
    ];
}

public class MedicamentosDisponibles
{
    public List<Medicamento> ListaMedicamentos { get; } =
    [
        new("Buprenorfina", ["0.2 mg", "2 mg", "8 mg", "0.3 mg/ml", "5 mcg/h", "10 mcg/h", "20 mcg/h"]),
        new("Metilfenidato", ["10 mg", "18 mg", "27 mg", "36 mg", "54 mg", "20 mg", "30 mg", "40 mg"]),
        new("Lisdexanfetamina", ["20 mg", "30 mg", "50 mg", "70 mg"]),
        new("Clonazepam", ["0.5 mg", "1 mg", "2 mg", "2.5 mg/ml", "1 mg/ml"]),
        new("Alprazolam", ["0.25 mg", "0.5 mg", "1 mg", "2 mg"]),
        new("Lorazepam", ["1 mg", "2 mg", "2 mg/ml", "4 mg/ml"]),
        new("Diazepam", ["5 mg", "10 mg", "10 mg/2 ml"]),
        new("Bromazepam", ["1.5 mg", "3 mg", "6 mg"]),
        new("Clobazam", ["10 mg", "20 mg"]),
        new("Zolpidem", ["5 mg", "10 mg", "6.25 mg", "12.5 mg"]),
        new("Zopiclona", ["7.5 mg"]),
        new("Eszopiclona", ["1 mg", "2 mg", "3 mg"]),
        new("Buspirona", ["5 mg", "10 mg"]),
        new("Sertralina", ["50 mg", "100 mg", "20 mg/ml"]),
        new("Fluoxetina", ["20 mg", "20 mg/5 ml"]),
        new("Escitalopram", ["10 mg", "20 mg", "10 mg/ml", "20 mg/ml"]),
        new("Citalopram", ["20 mg", "40 mg", "40 mg/ml"]),
        new("Paroxetina", ["10 mg", "20 mg", "30 mg", "40 mg"]),
        new("Fluvoxamina", ["50 mg", "100 mg"]),
        new("Venlafaxina", ["37.5 mg", "75 mg", "150 mg"]),
        new("Duloxetina", ["30 mg", "60 mg"]),
        new("Desvenlafaxina", ["50 mg", "100 mg"]),
        new("Milnaciprán", ["25 mg", "50 mg"]),
        new("Bupropión", ["150 mg", "300 mg"]),
        new("Mirtazapina", ["15 mg", "30 mg", "45 mg"]),
        new("Vortioxetina", ["5 mg", "10 mg", "15 mg", "20 mg", "20 mg/ml"]),
        new("Trazodona", ["50 mg", "100 mg", "150 mg"]),
        new("Agomelatina", ["25 mg"]),
        new("Mianserina", ["30 mg", "60 mg"]),
        new("Tianeptina", ["12.5 mg"]),
        new("Amitriptilina", ["25 mg", "50 mg", "75 mg"]),
        new("Clomipramina", ["25 mg, 75 mg"]),
        new("Imipramina", ["10 mg", "25 mg", "50 mg"]),
        new("Quetiapina", ["25 mg", "100 mg", "200 mg", "300 mg", "400 mg"]),
        new("Risperidona", ["1 mg", "2 mg", "3 mg", "4 mg", "1 mg/ml", "25 mg", "37.5 mg", "50 mg"]),
        new("Olanzapina", ["2.5 mg", "5 mg", "7.5 mg", "10 mg", "15 mg", "20 mg"]),
        new("Aripiprazol", ["5 mg", "10 mg", "15 mg", "30 mg", "1 mg/ml", "400 mg"]),
        new("Clozapina", ["25 mg", "100 mg"]),
        new("Paliperidona", ["3 mg", "6 mg", "9 mg", "75 mg", "100 mg", "150 mg"]),
        new("Lurasidona", ["20 mg", "40 mg", "80 mg"]),
        new("Brexpiprazol", ["0.5 mg", "1 mg", "2 mg", "3 mg", "4 mg"]),
        new("Haloperidol", ["5 mg", "10 mg", "2 mg/ml", "5 mg/ml", "50 mg/ml"]),
        new("Levomepromazina", ["25 mg", "100 mg", "40 mg/ml (gotas 4%)", "25 mg/1 ml"]),
        new("Sulpirida", ["50 mg", "200 mg", "50 mg/5 ml"]),
        new("Zuclopentixol", ["10 mg", "25 mg", "50 mg/ml", "200 mg/ml"]),
        new("Carbonato de Litio", ["300 mg", "400 mg"]),
        new("Valproato de Magnesio/Ácido Valproico", ["200 mg", "250 mg", "500 mg", "200 mg/ml"]),
        new("Lamotrigina", ["25 mg", "50 mg", "100 mg", "200 mg"]),
        new("Carbamazepina", ["200 mg", "400 mg", "100 mg/5 ml"]),
        new("Oxcarbazepina", ["300 mg", "600 mg", "60 mg/ml"]),
        new("Gabapentina", ["300 mg", "400 mg", "600 mg", "800 mg"]),
        new("Pregabalina", ["75 mg", "150 mg", "300 mg"]),
        new("Buspirona", ["5 mg", "10 mg"]),
        new("Hidroxizina", ["10 mg", "25 mg", "2 mg/ml"]),
        new("Propranolol", ["10 mg", "40 mg", "80 mg"]),
        new("Clonidina", ["0.1 mg", "0.15 mg"]),
        new("Atomoxetina", ["10 mg", "18 mg", "25 mg", "40 mg", "60 mg", "80 mg", "100 mg"]),
        new("Modafinilo", ["100 mg", "200 mg"]),
        new("Armodafinilo", ["50 mg", "150 mg", "250 mg"]),
        new("Pitolisant", ["4.5 mg", "18 mg"]),
        new("Ramelteón", ["8 mg"]),
        new("Donepezilo", ["5 mg", "10 mg"]),
        new("Rivastigmina", ["1.5 mg", "3 mg", "4.5 mg", "6 mg", "2 mg/ml", "4.6 mg/24h", "9.5 mg/24h", "13.3 mg/24h"]),
        new("Galantamina", ["8 mg", "16 mg", "24 mg", "4 mg/ml"]),
        new("Memantina", ["10 mg", "20 mg", "10 mg/g", "10 mg/ml"]),
        new("Naltrexona", ["50 mg", "380 mg"]),
        new("Acamprosato", ["333 mg"]),
        new("Disulfiram", ["250 mg", "500 mg"]),
        new("Melatonina", ["2 mg", "3 mg", "5 mg"]),
    ];
    public string[] Presentaciones { get; } = [
        "comprimidos",
        "comprimidos dispersables",
        "comprimidos/LC",
        "comprimidos entéricos",
        "comprimidos sublinguales",
        "concentrado oral",
        "cápsulas",
        "solución oral",
        "suspensión oral",
        "gotas orales",
        "cápsulas con gránulos entéricos",
        "cápsulas de liberación modificada",
        "comprimidos de liberación prolongada",
        "cápsulas de liberación prolongada",
        "comprimidos XL/SR",
        "bucodispersables",
        "grageas",
        "inmediata/XR",
        "inyectable de larga acción",
        "suspensión inyectable de liberación prolongada",
        "inyectable",
        "inyectable rápido",
        "decanoato inyectable",
        "acetato inyectable",
        "ampolletas inyectables",
        "solución inyectable",
        "sublingual",
        "solución/jarabe",
        "parches transdérmicos"
    ];
}