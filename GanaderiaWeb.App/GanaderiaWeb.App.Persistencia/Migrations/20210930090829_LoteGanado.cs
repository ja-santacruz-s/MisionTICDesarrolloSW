using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GanaderiaWeb.App.Persistencia.Migrations
{
    public partial class LoteGanado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LotesGanado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdGanadero = table.Column<int>(type: "int", nullable: false),
                    CantidadEjemplares = table.Column<int>(type: "int", nullable: false),
                    TotalHembras = table.Column<int>(type: "int", nullable: false),
                    TotalMachos = table.Column<int>(type: "int", nullable: false),
                    TotalMenos1Anio = table.Column<int>(type: "int", nullable: false),
                    Total1a2Anios = table.Column<int>(type: "int", nullable: false),
                    Total2a3Anios = table.Column<int>(type: "int", nullable: false),
                    TotalMas3Anios = table.Column<int>(type: "int", nullable: false),
                    CantidadCebuino = table.Column<int>(type: "int", nullable: false),
                    CantidadTaurino = table.Column<int>(type: "int", nullable: false),
                    CantidadCriollo = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotesGanado", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LotesGanado");
        }
    }
}
