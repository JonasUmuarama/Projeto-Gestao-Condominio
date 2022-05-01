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
            _moradorRepositorio.Adicionar(morador);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(MoradorModel morador)
        {
            _moradorRepositorio.Atualizar(morador);
            return RedirectToAction("Index");
        }

    }
}
