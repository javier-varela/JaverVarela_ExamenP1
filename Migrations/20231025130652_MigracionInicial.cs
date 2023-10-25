using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JaverVarela_ExamenP1.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JavierVarela_tabla",
                columns: table => new
                {
                    JVId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JVDescripcion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    JVNota = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JVIsTrue = table.Column<bool>(type: "bit", nullable: false),
                    JVFecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JavierVarela_tabla", x => x.JVId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JavierVarela_tabla");
        }
    }
}
