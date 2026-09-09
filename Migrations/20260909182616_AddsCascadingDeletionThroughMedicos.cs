using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace neurosintergia.Migrations
{
    /// <inheritdoc />
    public partial class AddsCascadingDeletionThroughMedicos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Credenciales_Medicos_MedicosId",
                table: "Credenciales");

            migrationBuilder.AddForeignKey(
                name: "FK_Credenciales_Medicos_MedicosId",
                table: "Credenciales",
                column: "MedicosId",
                principalTable: "Medicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Credenciales_Medicos_MedicosId",
                table: "Credenciales");

            migrationBuilder.AddForeignKey(
                name: "FK_Credenciales_Medicos_MedicosId",
                table: "Credenciales",
                column: "MedicosId",
                principalTable: "Medicos",
                principalColumn: "Id");
        }
    }
}
