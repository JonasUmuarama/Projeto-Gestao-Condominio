using GestãoCondomínio.Data;
using GestãoCondomínio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Repositorio
{
    public class PrestadorRepositorio : IPrestadorRepositorio
    {
        private readonly BancoContext _bancoContext;
        public PrestadorRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public PrestadorModel ListarPorId(int id)
        {
            return _bancoContext.Prestadores.FirstOrDefault(x => x.Id==id);

        }

        //listar dados
        public List<PrestadorModel> BuscarTodos()
        {
            return _bancoContext.Prestadores.ToList();
        }


        public PrestadorModel Adicionar(PrestadorModel prestador)
        {
            // Gravar no banco de dados

            _bancoContext.Prestadores.Add(prestador);
            _bancoContext.SaveChanges();
            return prestador;

        }

        public PrestadorModel Atualizar(PrestadorModel prestador)
        {
            PrestadorModel prestadorDB = ListarPorId(prestador.Id);
            if (prestadorDB == null) throw new Exception("Houve um erro na atualização do prestador!");
            prestadorDB.Nome = prestador.Nome;
            prestadorDB.RG = prestador.RG;
            prestadorDB.CPF = prestador.CPF;
            prestadorDB.Contato = prestador.Contato;
            prestador.Empresa = prestador.Empresa;

            _bancoContext.Prestadores.Update(prestadorDB);
            _bancoContext.SaveChanges();

            return prestadorDB;
        }

        public bool Deletar(int id)
        {
            PrestadorModel prestadorDB = ListarPorId(id);
            if (prestadorDB == null) throw new Exception("Houve um erro na exclusão do prestador!");
            _bancoContext.Prestadores.Remove(prestadorDB);
            _bancoContext.SaveChanges();
            return true;
        }

       
    }
}
