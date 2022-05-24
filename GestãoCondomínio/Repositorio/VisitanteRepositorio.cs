using GestãoCondomínio.Data;
using GestãoCondomínio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Repositorio
{
    public class VisitanteRepositorio : IVisitanteRepositorio
    {
        private readonly BancoContext _bancoContext;
        public VisitanteRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public VisitanteModel ListarPorId(int id)
        {
            return _bancoContext.Visitantes.FirstOrDefault(x => x.Id==id);

        }

        //listar dados
        public List<VisitanteModel> BuscarTodos()
        {
            return _bancoContext.Visitantes.ToList();
        }


        public VisitanteModel Adicionar(VisitanteModel visitante)
        {
            // Gravar no banco de dados

            _bancoContext.Visitantes.Add(visitante);
            _bancoContext.SaveChanges();
            return visitante;

        }

        public VisitanteModel Atualizar(VisitanteModel visitante)
        {
            VisitanteModel visitanteDB = ListarPorId(visitante.Id);
            if (visitanteDB == null) throw new Exception("Houve um erro na atualização do visitante!");
            visitanteDB.Nome = visitante.Nome;
            visitanteDB.RG = visitante.RG;
            visitanteDB.CPF = visitante.CPF;
            visitanteDB.Contato = visitante.Contato;
           
           

            _bancoContext.Visitantes.Update(visitanteDB);
            _bancoContext.SaveChanges();

            return visitanteDB;
        }

        public bool Deletar(int id)
        {
            VisitanteModel visitanteDB = ListarPorId(id);
            if (visitanteDB == null) throw new Exception("Houve um erro na exclusão do visitante!");
            _bancoContext.Visitantes.Remove(visitanteDB);
            _bancoContext.SaveChanges();
            return true;
        }

    }
}
