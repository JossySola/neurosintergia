using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace neurosintergia.Migrations
{
    /// <inheritdoc />
    public partial class StoreRecetaTratamientosAsJson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Recetas");

            migrationBuilder.DropColumn(
                name: "Dosis",
                table: "Recetas");

            migrationBuilder.DropColumn(
                name: "Frecuencia",
                table: "Recetas");

            migrationBuilder.DropColumn(
                name: "Medicamento",
                table: "Recetas");

            migrationBuilder.DropColumn(
                name: "PeriodoTiempo",
                table: "Recetas");

            migrationBuilder.DropColumn(
                name: "SinSuspender",
                table: "Recetas");

            migrationBuilder.RenameColumn(
                name: "Presentacion",
                table: "Recetas",
                newName: "Tratamiento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tratamiento",
                table: "Recetas",
                newName: "Presentacion");

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "Recetas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Dosis",
                table: "Recetas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Frecuencia",
                table: "Recetas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Medicamento",
                table: "Recetas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PeriodoTiempo",
                table: "Recetas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "SinSuspender",
                table: "Recetas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
