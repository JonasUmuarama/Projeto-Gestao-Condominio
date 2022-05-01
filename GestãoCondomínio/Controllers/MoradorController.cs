using GestãoCondomínio.Models;
using GestãoCondomínio.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Controllers
{
    public class MoradorController : Controller
    { private readonly IMoradorRepositorio _moradorRepositorio;
        public MoradorController(IMoradorRepositorio moradorRepositorio)
        {
            _moradorRepositorio = moradorRepositorio;
        }
        public IActionResult Index()
        {
           List <MoradorModel> moradores = _moradorRepositorio.BuscarTodos();
            return View(moradores);
        }


        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
           MoradorModel morador = _moradorRepositorio.ListarPorId(id);
            return View(morador);
        }

        public IActionResult Apagar(int id)
        {
            MoradorModel morador = _moradorRepositorio.ListarPorId(id);
            return View(morador);
        }

        public IActionResult Deletar(int id)
        {
            _moradorRepositorio.Deletar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Cadastrar(MoradorModel morador)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _moradorRepositorio.Adicionar(morador);
                    TempData["MensagemSucesso"] = "Morador cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }


                return View(morador);
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Erro ao cadastrar, tente novamnete,detalhe do erro :{ erro.Message}";
                return RedirectToAction("Index");
            }
            
        }

        [HttpPost]
        public IActionResult Editar(MoradorModel morador)
        {
            if(ModelState.IsValid)
            {
                _moradorRepositorio.Atualizar(morador);
                return RedirectToAction("Index");
            }

            return View(morador);
        }

    }
}
