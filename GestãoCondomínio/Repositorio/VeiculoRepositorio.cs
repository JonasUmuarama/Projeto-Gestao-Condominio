using GestãoCondomínio.Data;
using GestãoCondomínio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Repositorio
{
    public class VeiculoRepositorio : IVeiculoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public VeiculoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public VeiculoModel ListarPorId(int id)
        {
            return _bancoContext.Veiculos.FirstOrDefault(x => x.Id==id);

        }

        //listar dados
        public List<VeiculoModel> BuscarTodos()
        {
            return _bancoContext.Veiculos.ToList();
        }


        public VeiculoModel Adicionar(VeiculoModel veiculo)
        {
            // Gravar no banco de dados

            _bancoContext.Veiculos.Add(veiculo);
            _bancoContext.SaveChanges();
            return veiculo;

        }

        public VeiculoModel Atualizar(VeiculoModel veiculo)
        {
            VeiculoModel veiculoDB = ListarPorId(veiculo.Id);
            if (veiculoDB == null) throw new Exception("Houve um erro na atualização do veículo!");
            veiculoDB.Placa = veiculo.Placa;
            veiculoDB.Marca = veiculo.Marca;
            veiculoDB.Modelo = veiculo.Modelo;
            veiculoDB.Cor = veiculo.Cor;
            veiculoDB.Tipo = veiculo.Tipo;
           

            _bancoContext.Veiculos.Update(veiculoDB);
            _bancoContext.SaveChanges();

            return veiculoDB;
        }

        public bool Deletar(int id)
        {
            VeiculoModel veiculoDB = ListarPorId(id);
            if (veiculoDB == null) throw new Exception("Houve um erro na exclusão do veículo!");
            _bancoContext.Veiculos.Remove(veiculoDB);
            _bancoContext.SaveChanges();
            return true;
        }

       
    }
}
