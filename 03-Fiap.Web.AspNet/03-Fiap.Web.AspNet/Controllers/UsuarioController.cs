using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _03_Fiap.Web.AspNet.Models;

namespace _03_Fiap.Web.AspNet.Controllers
{
    public class UsuarioController : Controller
    {

        private static IList<Usuario> _banco = new List<Usuario>();

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
        public IActionResult Cadastrar(Usuario usuario)
        {
            ViewData["nome"] = usuario.Nome;
            ViewData["data"] = usuario.DataNascimento;
            ViewBag.endEletronico = usuario.Email;
            TempData["msg"] = "Usuario cadastrado";


            //Cadastra o objeto na lista
            _banco.Add(usuario);

            //Enviar o objeto para tela
            return View(usuario);
        }

       public IActionResult Listar()
        {
            return View(_banco);
        }




    }
}