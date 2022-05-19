using GestãoCondomínio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Repositorio
{
    public interface IVeiculoRepositorio
    { 
        VeiculoModel ListarPorId(int id);
        List<VeiculoModel> BuscarTodos();
        VeiculoModel Adicionar(VeiculoModel veiculo);
        VeiculoModel Atualizar(VeiculoModel veiculo);
        bool Deletar(int id);

    }


}
