using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Models
{
    public class MoradorModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string RG { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string CPF{ get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        [Phone(ErrorMessage =" O contato informado não é válido!")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        [EmailAddress(ErrorMessage ="O e-mail não é válido!")]
        public string Email{ get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string  Apartamento { get; set; }

    }
}
