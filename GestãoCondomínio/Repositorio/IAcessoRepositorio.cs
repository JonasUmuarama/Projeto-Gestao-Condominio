using GestãoCondomínio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Repositorio
{
    public interface IAcessoRepositorio
    { 
        AcessoModel ListarPorId(int id);
        List<AcessoModel> BuscarTodos();
        AcessoModel Adicionar(AcessoModel acesso);
        AcessoModel Atualizar(AcessoModel acesso);
        bool Deletar(int id);

    }


}
