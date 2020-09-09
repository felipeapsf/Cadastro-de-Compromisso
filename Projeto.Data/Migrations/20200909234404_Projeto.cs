using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.Data.Migrations
{
    public partial class Projeto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compromisso",
                columns: table => new
                {
                    IdCompromisso = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 150, nullable: false),
                    Local = table.Column<string>(maxLength: 50, nullable: false),
                    DataHora = table.Column<DateTime>(type: "date", nullable: false),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compromisso", x => x.IdCompromisso);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compromisso");
        }
    }
}
