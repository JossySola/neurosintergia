using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace neurosintergia.Migrations
{
    /// <inheritdoc />
    public partial class RefactorsPacientesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LugarNacimiento",
                table: "Pacientes",
                newName: "PP_Otros");

            migrationBuilder.RenameColumn(
                name: "Celular",
                table: "Pacientes",
                newName: "ViveCon");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EstadoNacimiento",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrupoEtnico",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Alcohol",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Alzheimer",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Anemia",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Ansiedad",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Artritis",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Cancer",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Corazon",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Demencia",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Depresion",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Diabetes",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_DoloresCabeza",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Drogadiccion",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Epilepsia",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Gastritis",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Higado",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Hipertension",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "HF_Otros",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HF_Rinon",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HF_Tiroides",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "HabitaEn",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Municipio",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MunicipioNacimiento",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notas",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PNP_Alcohol",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PNP_Cafeina",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PNP_Otros",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "PNP_Sustancias",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PNP_Tabaco",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Alcohol",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Alzheimer",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Anemia",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Ansiedad",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Artritis",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Cancer",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Corazon",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Demencia",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Depresion",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Diabetes",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_DoloresCabeza",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Drogadiccion",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Epilepsia",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Gastritis",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Higado",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Hipertension",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Rinon",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_Tiroides",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PP_VIH",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Padecimiento",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Profesion",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resumen",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelefonoCelular",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tratamiento",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "EstadoNacimiento",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "GrupoEtnico",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Alcohol",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Alzheimer",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Anemia",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Ansiedad",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Artritis",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Cancer",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Corazon",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Demencia",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Depresion",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Diabetes",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_DoloresCabeza",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Drogadiccion",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Epilepsia",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Gastritis",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Higado",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Hipertension",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Otros",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Rinon",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HF_Tiroides",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "HabitaEn",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Municipio",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "MunicipioNacimiento",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Notas",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PNP_Alcohol",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PNP_Cafeina",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PNP_Otros",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PNP_Sustancias",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PNP_Tabaco",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Alcohol",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Alzheimer",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Anemia",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Ansiedad",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Artritis",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Cancer",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Corazon",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Demencia",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Depresion",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Diabetes",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_DoloresCabeza",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Drogadiccion",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Epilepsia",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Gastritis",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Higado",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Hipertension",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Rinon",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_Tiroides",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PP_VIH",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Padecimiento",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Profesion",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Resumen",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "TelefonoCelular",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Tratamiento",
                table: "Pacientes");

            migrationBuilder.RenameColumn(
                name: "ViveCon",
                table: "Pacientes",
                newName: "Celular");

            migrationBuilder.RenameColumn(
                name: "PP_Otros",
                table: "Pacientes",
                newName: "LugarNacimiento");
        }
    }
}
