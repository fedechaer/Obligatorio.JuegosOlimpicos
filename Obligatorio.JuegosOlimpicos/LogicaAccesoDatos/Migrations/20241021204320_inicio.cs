using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogicaAccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Paises",
                newName: "NomDelegado");

            migrationBuilder.RenameColumn(
                name: "NombreCompleto",
                table: "Atletas",
                newName: "Nombre");

            migrationBuilder.AlterColumn<int>(
                name: "Rol",
                table: "Usuarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "AnioInclusion",
                table: "Disciplina",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Atletas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Atletas");

            migrationBuilder.RenameColumn(
                name: "NomDelegado",
                table: "Paises",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Atletas",
                newName: "NombreCompleto");

            migrationBuilder.AlterColumn<string>(
                name: "Rol",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AnioInclusion",
                table: "Disciplina",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
