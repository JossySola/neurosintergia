using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace neurosintergia.Migrations
{
    /// <inheritdoc />
    public partial class AddsToOnModelCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicos_Funciones",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MedicoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grupo_I = table.Column<bool>(type: "bit", nullable: false),
                    Grupo_II = table.Column<bool>(type: "bit", nullable: false),
                    Grupo_III = table.Column<bool>(type: "bit", nullable: false),
                    Grupo_IV = table.Column<bool>(type: "bit", nullable: false),
                    Grupo_V = table.Column<bool>(type: "bit", nullable: false),
                    Grupo_VI = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos_Funciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicos_Funciones_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicos_Funciones");
        }
    }
}
