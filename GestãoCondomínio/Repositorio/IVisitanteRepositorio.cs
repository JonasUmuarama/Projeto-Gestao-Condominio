using GestãoCondomínio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Repositorio
{
    public interface IVisitanteRepositorio
    { 
        VisitanteModel ListarPorId(int id);
        List<VisitanteModel> BuscarTodos();
        VisitanteModel Adicionar(VisitanteModel visitante);
        VisitanteModel Atualizar(VisitanteModel visitante);
        bool Deletar(int id);

    }


}
