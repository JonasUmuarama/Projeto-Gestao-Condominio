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
            return View();
        }



    }
}
