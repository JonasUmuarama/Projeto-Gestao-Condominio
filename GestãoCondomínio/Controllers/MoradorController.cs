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

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(MoradorModel morador)
        {
            _moradorRepositorio.Adicionar(morador);
            return RedirectToAction("Index");
        }

    }
}
