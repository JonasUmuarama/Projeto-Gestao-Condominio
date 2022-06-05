using Microsoft.EntityFrameworkCore.Migrations;

namespace GestãoCondomínio.Migrations
{
    public partial class Alteracao2TabelaAcesso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acessos_Veiculos_VeiculoModelId",
                table: "Acessos");

            migrationBuilder.DropIndex(
                name: "IX_TbPessoas_IdVeiculo",
                table: "TbPessoas");

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
                name: "VeiculoModelId",
                table: "Acessos");

            migrationBuilder.CreateIndex(
                name: "IX_TbPessoas_IdVeiculo",
                table: "TbPessoas",
                column: "IdVeiculo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TbPessoas_IdVeiculo",
                table: "TbPessoas");

            migrationBuilder.AddColumn<int>(
                name: "IdPessoa",
                table: "Veiculos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVeiculo",
                table: "Acessos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Acessos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VeiculoModelId",
                table: "Acessos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TbPessoas_IdVeiculo",
                table: "TbPessoas",
                column: "IdVeiculo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Acessos_VeiculoModelId",
                table: "Acessos",
                column: "VeiculoModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Acessos_Veiculos_VeiculoModelId",
                table: "Acessos",
                column: "VeiculoModelId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
