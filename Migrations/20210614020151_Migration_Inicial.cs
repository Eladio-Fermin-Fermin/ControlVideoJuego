using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlVideoJuego.Migrations
{
    public partial class Migration_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consolas",
                columns: table => new
                {
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Fabricante = table.Column<string>(type: "TEXT", nullable: true),
                    PrecioRenta = table.Column<double>(type: "REAL", nullable: false),
                    Version = table.Column<double>(type: "REAL", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PrecioVenta = table.Column<double>(type: "REAL", nullable: false),
                    Almacenamiento = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consolas", x => x.Nombre);
                });

            migrationBuilder.CreateTable(
                name: "Juegos",
                columns: table => new
                {
                    JuegoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Fabricante = table.Column<string>(type: "TEXT", nullable: true),
                    Plataforma = table.Column<string>(type: "TEXT", nullable: true),
                    PrecioRenta = table.Column<double>(type: "REAL", nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Categoria = table.Column<string>(type: "TEXT", nullable: true),
                    PrecioVenta = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juegos", x => x.JuegoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consolas");

            migrationBuilder.DropTable(
                name: "Juegos");
        }
    }
}
