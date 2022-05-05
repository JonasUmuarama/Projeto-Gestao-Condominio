using GestãoCondomínio.Data;
using GestãoCondomínio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Repositorio
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private readonly BancoContext _bancoContext;
        public FuncionarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public FuncionarioModel ListarPorId(int id)
        {
            return _bancoContext.Funcionarios.FirstOrDefault(x => x.Id==id);

        }

        //listar dados
        public List<FuncionarioModel> BuscarTodos()
        {
            return _bancoContext.Funcionarios.ToList();
        }


        public FuncionarioModel Adicionar(FuncionarioModel funcionario)
        {
            // Gravar no banco de dados

            _bancoContext.Funcionarios.Add(funcionario);
            _bancoContext.SaveChanges();
            return funcionario;

        }

        public FuncionarioModel Atualizar(FuncionarioModel funcionario)
        {
            FuncionarioModel funcionarioDB = ListarPorId(funcionario.Id);
            if (funcionarioDB == null) throw new Exception("Houve um erro na atualização do morador!");
            funcionarioDB.Nome = funcionario.Nome;
            funcionarioDB.RG = funcionario.RG;
            funcionarioDB.Funcao = funcionario.Funcao;
            funcionarioDB.Telefone = funcionario.Telefone;
            funcionarioDB.Descricao = funcionario.Descricao;

            _bancoContext.Funcionarios.Update(funcionarioDB);
            _bancoContext.SaveChanges();

            return funcionarioDB;
        }

        public bool Deletar(int id)
        {
            FuncionarioModel funcionarioDB = ListarPorId(id);
            if (funcionarioDB == null) throw new Exception("Houve um erro na exclusão do funcionário!");
            _bancoContext.Funcionarios.Remove(funcionarioDB);
            _bancoContext.SaveChanges();
            return true;
        }

        List<FuncionarioModel> IFuncionarioRepositorio.BuscarTodos()
        {
            throw new NotImplementedException();
        }

       
    }
}
