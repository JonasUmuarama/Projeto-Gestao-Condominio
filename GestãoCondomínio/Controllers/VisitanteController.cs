using GestãoCondomínio.Models;
using GestãoCondomínio.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Controllers
{
    public class VisitanteController : Controller
    {
        private readonly IVisitanteRepositorio _visitanteRepositorio;
        public VisitanteController(IVisitanteRepositorio visitanteRepositorio)
        {
            _visitanteRepositorio = visitanteRepositorio;
        }

        public IActionResult Index()
        {
            List<VisitanteModel> visitantes = _visitanteRepositorio.BuscarTodos();
            return View(visitantes);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            VisitanteModel visitante = _visitanteRepositorio.BuscarTodos();
            return View(visitante);
        }

        public IActionResult Apagar(int id)
        {
            VisitanteModel visitante = _visitanteRepositorio.ListarPorId(id);
            return View(visitante);
        }

        public IActionResult Deletar(int id)
        {
            try
            {
                bool apagado = _visitanteRepositorio.Deletar(id);
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
        public IActionResult Cadastrar(VisitanteModel visitante)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _visitanteRepositorio.Adicionar(visitante);
                    TempData["MensagemSucesso"] = "Veículo cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }


                return View(visitante);
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Erro ao cadastrar, tente novamnete,detalhe do erro :{ erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Editar(VisitanteModel visitante)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _visitanteRepositorio.Atualizar(visitante);
                    TempData["MensagemSucesso"] = "Veículo alterado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(visitante);
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Erro ao atualizar, tente novamnete,detalhe do erro :{ erro.Message}";
                return RedirectToAction("Index");
            }


        }
    }
}