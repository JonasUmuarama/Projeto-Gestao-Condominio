using GestãoCondomínio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Repositorio
{
    public interface IPrestadorRepositorio
    { 
        PrestadorModel ListarPorId(int id);
        List<PrestadorModel> BuscarTodos();
        PrestadorModel Adicionar(PrestadorModel prestador);
        PrestadorModel Atualizar(PrestadorModel prestador);
        bool Deletar(int id);

    }


}
