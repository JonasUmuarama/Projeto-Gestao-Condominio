using GestãoCondomínio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Repositorio
{
    public interface IMoradorRepositorio
    { 
        MoradorModel ListarPorId(int id);
        List<MoradorModel> BuscarTodos();
        MoradorModel Adicionar(MoradorModel morador);
        MoradorModel Atualizar(MoradorModel morador);
        bool Deletar(int id);

    }


}
