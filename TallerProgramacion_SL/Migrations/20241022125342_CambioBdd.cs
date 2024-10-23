using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerProgramacion_SL.Migrations
{
    /// <inheritdoc />
    public partial class CambioBdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Jugador",
                newName: "JugadorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Equipo",
                newName: "EquipoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JugadorId",
                table: "Jugador",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EquipoId",
                table: "Equipo",
                newName: "Id");
        }
    }
}
