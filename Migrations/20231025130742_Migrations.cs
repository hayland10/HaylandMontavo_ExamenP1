using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaylandMontavo_ExamenP1.Migrations
{
    public partial class Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HaylandMontalvo_tabla",
                columns: table => new
                {
                    IdMonster = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hmDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hmNombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    hmNumeroMonsters = table.Column<int>(type: "int", nullable: false),
                    hmPrecio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    hmPrimeraVez = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HaylandMontalvo_tabla", x => x.IdMonster);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HaylandMontalvo_tabla");
        }
    }
}
