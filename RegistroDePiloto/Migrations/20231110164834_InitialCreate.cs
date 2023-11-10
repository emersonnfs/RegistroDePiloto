using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistroDePiloto.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pilots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Idade = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Nacionalidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NumeroLicenca = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DataExpiracaoLicenca = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    TipoLicencaPiloto = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilots", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pilots");
        }
    }
}
