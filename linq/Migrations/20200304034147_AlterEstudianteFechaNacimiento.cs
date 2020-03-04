using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace linq.Migrations
{
    public partial class AlterEstudianteFechaNacimiento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Estudiante",
                schema:"Pruebas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                schema: "Pruebas",
                table: "Estudiante");
        }
    }
}
