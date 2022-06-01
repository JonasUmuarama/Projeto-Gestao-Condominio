using GestãoCondomínio.Models;
using GestãoCondomínio.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Controllers
{
    public class AcessoMoradorController : Controller
    {
        private readonly IAcessoRepositorio _acessoRepositorio;
       

        public AcessoMoradorController(IAcessoRepositorio acessoRepositorio)
        {
            _acessoRepositorio = acessoRepositorio;
           
        }
        public IActionResult Index()
        {
            List<AcessoModel> acessos = _acessoRepositorio.BuscarTodos();

            return View(acessos);    
        }


    }
}
