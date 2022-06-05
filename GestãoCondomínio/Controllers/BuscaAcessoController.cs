using GestãoCondomínio.Models;
using GestãoCondomínio.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestãoCondomínio.Services;

namespace GestãoCondomínio.Controllers
{
    public class BuscaAcessoController : Controller
    {
        private readonly IAcessoRepositorio _acessoRepositorio;
        private readonly AcessoService _acessoService;


        public BuscaAcessoController(IAcessoRepositorio acessoRepositorio, AcessoService acessoService)
        {
            _acessoRepositorio = acessoRepositorio;
            _acessoService = acessoService;

        }
        public IActionResult Index()
        {
            List<AcessoModel> acessos = _acessoRepositorio.BuscarTodos();

            return View(acessos);
        }

        public IActionResult BuscaAcesso(DateTime? minDate, DateTime? maxDate)
        {
            var result = _acessoService.FindByDate(minDate, maxDate);

            return View(result);
        }

        public IActionResult Cadastrar()
        {

            return View();
        }
        public IActionResult Editar(int id)
        {
            AcessoModel acesso = _acessoRepositorio.ListarPorId(id);
            return View(acesso);
        }
        public IActionResult Apagar(int id)
        {
            AcessoModel acesso = _acessoRepositorio.ListarPorId(id);
            return View(acesso);
        }
        public IActionResult Deletar(int id)
        {
            try
            {
                bool apagado = _acessoRepositorio.Deletar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Acesso excluído com sucesso!";
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
        public IActionResult Cadastrar(AcessoModel acesso)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _acessoRepositorio.Adicionar(acesso);
                    TempData["MensagemSucesso"] = "Acesso cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }


                return View(acesso);
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Erro ao cadastrar, tente novamnete,detalhe do erro :{ erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Editar(AcessoModel acesso)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _acessoRepositorio.Atualizar(acesso);
                    TempData["MensagemSucesso"] = "Acesso alterado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(acesso);
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Erro ao atualizar, tente novamnete,detalhe do erro :{ erro.Message}";
                return RedirectToAction("Index");
            }

        }

    }
}
