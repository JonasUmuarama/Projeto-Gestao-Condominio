using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Models
{
    public class TbPessoaModel
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }

        public string Telefone { get; set; }
        public string Perfil { get; set; }
        public int IdVeiculo { get; set; }
        public virtual TbVeiculo TbVeiculo { get; set; }
        public virtual List<Acesso> Acessos { get; set; }

    }
}
