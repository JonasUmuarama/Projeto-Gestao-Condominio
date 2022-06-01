using Microsoft.EntityFrameworkCore.Migrations;

namespace GestãoCondomínio.Migrations
{
    public partial class Alteração2TbPessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPessoa",
                table: "Veiculos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVeiculo",
                table: "Acessos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Acessos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TbPessoaModelIdPessoa",
                table: "Acessos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VeiculoModelId",
                table: "Acessos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TbPessoas",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    RG = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Perfil = table.Column<string>(nullable: true),
                    IdVeiculo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbPessoas", x => x.IdPessoa);
                    table.ForeignKey(
                        name: "FK_TbPessoas_Veiculos_IdVeiculo",
                        column: x => x.IdVeiculo,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acessos_TbPessoaModelIdPessoa",
                table: "Acessos",
                column: "TbPessoaModelIdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Acessos_VeiculoModelId",
                table: "Acessos",
                column: "VeiculoModelId");

            migrationBuilder.CreateIndex(
                name: "IX_TbPessoas_IdVeiculo",
                table: "TbPessoas",
                column: "IdVeiculo",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Acessos_TbPessoas_TbPessoaModelIdPessoa",
                table: "Acessos",
                column: "TbPessoaModelIdPessoa",
                principalTable: "TbPessoas",
                principalColumn: "IdPessoa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Acessos_Veiculos_VeiculoModelId",
                table: "Acessos",
                column: "VeiculoModelId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acessos_TbPessoas_TbPessoaModelIdPessoa",
                table: "Acessos");

            migrationBuilder.DropForeignKey(
                name: "FK_Acessos_Veiculos_VeiculoModelId",
                table: "Acessos");

            migrationBuilder.DropTable(
                name: "TbPessoas");

            migrationBuilder.DropIndex(
                name: "IX_Acessos_TbPessoaModelIdPessoa",
                table: "Acessos");

            migrationBuilder.DropIndex(
                name: "IX_Acessos_VeiculoModelId",
                table: "Acessos");

            migrationBuilder.DropColumn(
                name: "IdPessoa",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "IdVeiculo",
                table: "Acessos");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Acessos");

            migrationBuilder.DropColumn(
                name: "TbPessoaModelIdPessoa",
                table: "Acessos");

            migrationBuilder.DropColumn(
                name: "VeiculoModelId",
                table: "Acessos");
        }
    }
}
