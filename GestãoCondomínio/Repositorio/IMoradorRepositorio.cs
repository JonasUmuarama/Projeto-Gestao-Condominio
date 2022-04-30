using GestãoCondomínio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Repositorio
{
    public interface IMoradorRepositorio
    {
        List<MoradorModel> BuscarTodos();
        MoradorModel Adicionar(MoradorModel morador);


    }
}
