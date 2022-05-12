using GestãoCondomínio.Models;
using GestãoCondomínio.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoCondomínio.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;

        public FuncionarioController(IFuncionarioRepositorio funcionarioRepositorio)
        {
            _funcionarioRepositorio = funcionarioRepositorio;
        }
        public IActionResult Index()
        {
            List<FuncionarioModel> funcionarios = _funcionarioRepositorio.BuscarTodos();

            return View(funcionarios);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(FuncionarioModel funcionario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _funcionarioRepositorio.Adicionar(funcionario);
                    TempData["MensagemSucesso"] = "Funcionário cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }


                return View(funcionario);
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Erro ao cadastrar, tente novamnete,detalhe do erro :{ erro.Message}";
                return RedirectToAction("Index");
            }

        }


        [HttpPost]
        public IActionResult Editar(FuncionarioModel funcionario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _funcionarioRepositorio.Atualizar(funcionario);
                    TempData["MensagemSucesso"] = "Morador alterado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(funcionario);
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Erro ao atualizar, tente novamnete,detalhe do erro :{ erro.Message}";
                return RedirectToAction("Index");
            }

        }
    }
}
