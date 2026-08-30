using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace neurosintergia.Migrations
{
    /// <inheritdoc />
    public partial class ConnectProfilesToIdentityUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_Admins_AspNetUsers_Id",
                table: "Admins",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_AspNetUsers_Id",
                table: "Medicos",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_AspNetUsers_Id",
                table: "Pacientes",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_AspNetUsers_Id",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_AspNetUsers_Id",
                table: "Medicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_AspNetUsers_Id",
                table: "Pacientes");
        }
    }
}
