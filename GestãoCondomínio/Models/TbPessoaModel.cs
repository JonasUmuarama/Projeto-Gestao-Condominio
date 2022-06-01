using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestãoCondomínio.Models
{
    public class TbPessoaModel
    {  
        [Key]
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }

        public string Telefone { get; set; }
        public string Perfil { get; set; }
        public int IdVeiculo { get; set; }
        [ForeignKey ("IdVeiculo")]
        public virtual VeiculoModel VeiculoModel { get; set; }
        public virtual List<AcessoModel> Acessos { get; set; }

    }
}
