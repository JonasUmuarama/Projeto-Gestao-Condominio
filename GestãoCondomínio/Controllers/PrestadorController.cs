using GestãoCondomínio.Models;
using GestãoCondomínio.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Controllers
{
    public class PrestadorController : Controller
    {
        private readonly IPrestadorRepositorio _prestadorRepositorio;

        public PrestadorController(IPrestadorRepositorio prestadorRepositorio)
        {
            _prestadorRepositorio = prestadorRepositorio;
        }
        public IActionResult Index()
        {
            List<PrestadorModel> prestadores = _prestadorRepositorio.BuscarTodos();
            return View(prestadores);
            
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            PrestadorModel prestador = _prestadorRepositorio.ListarPorId(id);
            return View(prestador);
        }

        public IActionResult Apagar(int id)
        {
            PrestadorModel prestador = _prestadorRepositorio.ListarPorId(id);
            return View(prestador);
        }

        public IActionResult Deletar(int id)
        {
            try
            {
                bool apagado = _prestadorRepositorio.Deletar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Prestador de Serviço excluído com sucesso!";
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
        public IActionResult Cadastrar(PrestadorModel prestador)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _prestadorRepositorio.Adicionar(prestador);
                    TempData["MensagemSucesso"] = "Prestador de Serviço cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }


                return View(prestador);
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Erro ao cadastrar, tente novamnete,detalhe do erro :{ erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Editar(PrestadorModel prestador)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _prestadorRepositorio.Atualizar(prestador);
                    TempData["MensagemSucesso"] = "Prestador de Serviço alterado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(prestador);
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Erro ao atualizar, tente novamnete,detalhe do erro :{ erro.Message}";
                return RedirectToAction("Index");
            }



        }

        }
    }
