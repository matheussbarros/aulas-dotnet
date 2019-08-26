using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02__Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02__Fiap.Web.AspNet.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] //Abrir a página do formulário
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost] //Cadastra no clique do botão
        public IActionResult Cadastrar(Cliente cliente)
        {
            ViewData["nome"] = cliente.Nome;
            ViewBag.cpf = cliente.Cpf;
            TempData["msg"] = "Usuario cadastrado";
            return View();
        }

    }
}