using GestãoCondomínio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Repositorio
{
    public interface IFuncionarioRepositorio
    { 
        FuncionarioModel ListarPorId(int id);
        List<FuncionarioModel> BuscarTodos();
        FuncionarioModel Adicionar(FuncionarioModel funcionario);
        FuncionarioModel Atualizar(FuncionarioModel funcionario);
        bool Deletar(int id);

    }


}
