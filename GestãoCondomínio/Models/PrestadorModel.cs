using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Models
{
    public class PrestadorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF {get;set;}
        public string Contato { get; set; }
        public string Empresa { get; set; }
    }
}
