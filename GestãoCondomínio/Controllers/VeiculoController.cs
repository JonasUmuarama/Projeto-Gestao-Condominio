using GestãoCondomínio.Models;
using GestãoCondomínio.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly IVeiculoRepositorio _veiculoRepositorio;

        public VeiculoController(IVeiculoRepositorio veiculoRepositorio)
        {
            _veiculoRepositorio = veiculoRepositorio;
        }
        public IActionResult Index()
        {
            List<VeiculoModel> veiculos = _veiculoRepositorio.BuscarTodos();
            return View(veiculos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            VeiculoModel veiculo = _veiculoRepositorio.ListarPorId(id);
            return View(veiculo);
        }

        public IActionResult Apagar(int id)
        {
            VeiculoModel veiculo = _veiculoRepositorio.ListarPorId(id);
            return View(veiculo);
        }

        public IActionResult Deletar(int id)
        {
            try
            {
                bool apagado = _veiculoRepositorio.Deletar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Veículo excluído com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = $"Erro ao excluir, tente novamente";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao excluir, tente novamente, mais detalhes: {erro.Message} ";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(VeiculoModel veiculo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _veiculoRepositorio.Adicionar(veiculo);
                    TempData["MensagemSucesso"] = "Veículo cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }


                return View(veiculo);
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Erro ao cadastrar, tente novamnete,detalhe do erro :{ erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Editar(VeiculoModel veiculo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _veiculoRepositorio.Atualizar(veiculo);
                    TempData["MensagemSucesso"] = "Veículo alterado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(veiculo);
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Erro ao atualizar, tente novamnete,detalhe do erro :{ erro.Message}";
                return RedirectToAction("Index");
            }

        }
    }
}
