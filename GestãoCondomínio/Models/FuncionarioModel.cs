using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Models
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome do funcionário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o RG do funcionário")]
        public string RG { get; set; }
        [Required(ErrorMessage = "Digite o Telefone do funcionário")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Digite a Função do funcionário")]
        public string Funcao { get; set; }
        [Required(ErrorMessage = "Digite a Descrição do funcionário")]
        public string Descricao { get; set; }

    }
}
