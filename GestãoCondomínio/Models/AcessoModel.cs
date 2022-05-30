using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Models
{
    public class AcessoModel
    {
        public int Id { get; set; }
        
        public string Veiculo { get; set; }
        public string Condutor { get; set; }
        public string Documento { get; set; }
        public DateTime Entrada { get; set; }

        public DateTime? Saida { get; set; }

        public int PessoaId { get; set; }
        public virtual TbPessoaModel TbPessoaModel { get; set; }
        public int IdVeiculo { get; set; }
        public virtual VeiculoModel VeiculoModel { get; set; }
        public string Destino { get; set; }


    }
}
