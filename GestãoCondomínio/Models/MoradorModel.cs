﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Models
{
    public class MoradorModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF{ get; set; }
        public string Telefone { get; set; }
        public string Email{ get; set; }
        public string  Apartamento { get; set; }

    }
}
