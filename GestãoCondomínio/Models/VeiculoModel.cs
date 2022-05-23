using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Models
{
    public class VeiculoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite a placa do veículo")]
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Tipo { get; set; }

    }
}
