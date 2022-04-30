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

        
    }
}
