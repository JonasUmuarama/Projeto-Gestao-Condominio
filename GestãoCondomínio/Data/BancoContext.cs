using GestãoCondomínio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext>options) : base(options)
        {
        }

        public DbSet<MoradorModel> Moradores { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }

        public DbSet<VeiculoModel> Veiculos { get; set; }

        public DbSet<PrestadorModel> Prestadores { get; set; }

        public DbSet<VisitanteModel> Visitantes { get; set; }

        public DbSet<AcessoModel> Acessos { get; set; }

        public DbSet<TbPessoaModel> TbPessoas { get; set; }

    }
}
