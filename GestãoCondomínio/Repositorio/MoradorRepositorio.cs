using GestãoCondomínio.Data;
using GestãoCondomínio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Repositorio
{
    public class MoradorRepositorio : IMoradorRepositorio
    {
        private readonly BancoContext _bancoContext;
        public MoradorRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public MoradorModel ListarPorId(int id)
        {
            return _bancoContext.Moradores.FirstOrDefault(x => x.Id==id);

        }

        //listar dados
        public List<MoradorModel> BuscarTodos()
        {
            return _bancoContext.Moradores.ToList();
        }


        public MoradorModel Adicionar(MoradorModel morador)
        {
            // Gravar no banco de dados

            _bancoContext.Moradores.Add(morador);
            _bancoContext.SaveChanges();
            return morador;

        }

        public MoradorModel Atualizar(MoradorModel morador)
        {
            MoradorModel moradorDB = ListarPorId(morador.Id);
            if (moradorDB == null) throw new Exception("Houve um erro na atualização do morador!");
            moradorDB.Nome = morador.Nome;
            moradorDB.RG = morador.RG;
            moradorDB.CPF = morador.CPF;
            moradorDB.Telefone = morador.Telefone;
            moradorDB.Email = morador.Email;
            moradorDB.Apartamento = morador.Apartamento;

            _bancoContext.Moradores.Update(moradorDB);
            _bancoContext.SaveChanges();

            return moradorDB;
        }

        public bool Deletar(int id)
        {
            MoradorModel moradorDB = ListarPorId(id);
            if (moradorDB == null) throw new Exception("Houve um erro na exclusão do morador!");
            _bancoContext.Moradores.Remove(moradorDB);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
