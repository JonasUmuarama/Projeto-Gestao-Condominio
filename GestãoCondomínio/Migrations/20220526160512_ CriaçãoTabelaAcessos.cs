using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestãoCondomínio.Migrations
{
    public partial class CriaçãoTabelaAcessos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acessos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Veiculo = table.Column<string>(nullable: true),
                    Condutor = table.Column<string>(nullable: true),
                    Documento = table.Column<string>(nullable: true),
                    Entrada = table.Column<DateTime>(nullable: false),
                    Saida = table.Column<DateTime>(nullable: true),
                    Destino = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acessos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acessos");
        }
    }
}
