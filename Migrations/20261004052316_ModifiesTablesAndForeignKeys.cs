using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace neurosintergia.Migrations
{
    /// <inheritdoc />
    public partial class ModifiesTablesAndForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Funciones_AspNetUsers_Id",
                table: "Medicos_Funciones");

            migrationBuilder.AlterColumn<string>(
                name: "PacienteId",
                table: "Recetas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MedicoId",
                table: "Recetas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MedicoId",
                table: "Medicos_Funciones",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Recetas_MedicoId",
                table: "Recetas",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Recetas_PacienteId",
                table: "Recetas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_Funciones_MedicoId",
                table: "Medicos_Funciones",
                column: "MedicoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Funciones_Medicos_MedicoId",
                table: "Medicos_Funciones",
                column: "MedicoId",
                principalTable: "Medicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recetas_Medicos_MedicoId",
                table: "Recetas",
                column: "MedicoId",
                principalTable: "Medicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recetas_Pacientes_PacienteId",
                table: "Recetas",
                column: "PacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Funciones_Medicos_MedicoId",
                table: "Medicos_Funciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Recetas_Medicos_MedicoId",
                table: "Recetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Recetas_Pacientes_PacienteId",
                table: "Recetas");

            migrationBuilder.DropIndex(
                name: "IX_Recetas_MedicoId",
                table: "Recetas");

            migrationBuilder.DropIndex(
                name: "IX_Recetas_PacienteId",
                table: "Recetas");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_Funciones_MedicoId",
                table: "Medicos_Funciones");

            migrationBuilder.AlterColumn<string>(
                name: "PacienteId",
                table: "Recetas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MedicoId",
                table: "Recetas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MedicoId",
                table: "Medicos_Funciones",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Funciones_AspNetUsers_Id",
                table: "Medicos_Funciones",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
