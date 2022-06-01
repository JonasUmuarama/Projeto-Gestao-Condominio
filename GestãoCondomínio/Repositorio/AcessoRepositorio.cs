using GestãoCondomínio.Data;
using GestãoCondomínio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Repositorio
{
    public class AcessoRepositorio : IAcessoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public AcessoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public AcessoModel ListarPorId(int id)
        {
            return _bancoContext.Acessos.FirstOrDefault(x => x.Id==id);

        }

        //listar dados
        public List<AcessoModel> BuscarTodos()
        {
            return _bancoContext.Acessos.ToList();
        }


        public AcessoModel Adicionar(AcessoModel acesso)
        {
            // Gravar no banco de dados

            _bancoContext.Acessos.Add(acesso);
            _bancoContext.SaveChanges();
            return acesso;

        }

        public AcessoModel Atualizar(AcessoModel acesso)
        {
            AcessoModel acessoDB = ListarPorId(acesso.Id);
            if (acessoDB == null) throw new Exception("Houve um erro na atualização do acesso!");
            acessoDB.Veiculo = acesso.Veiculo;
            acessoDB.Condutor = acesso.Condutor;
            acessoDB.Documento = acesso.Documento;
            acessoDB.Entrada = acesso.Entrada;
            acessoDB.Saida = acesso.Saida;
           

            _bancoContext.Acessos.Update(acessoDB);
            _bancoContext.SaveChanges();

            return acessoDB;
        }

        public bool Deletar(int id)
        {
            AcessoModel acessoDB = ListarPorId(id);
            if (acessoDB == null) throw new Exception("Houve um erro na exclusão do acesso!");
            _bancoContext.Acessos.Remove(acessoDB);
            _bancoContext.SaveChanges();
            return true;
        }

       
    }
}
