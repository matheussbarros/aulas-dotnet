using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _05_Fiap.Web.AspNet.Models;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class SerieController : Controller
    {
        private static IList<Serie> _lista = new List<Serie>();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Listar()
        {
            return View(_lista);
        }


        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }


        public IActionResult Cadastrar (Serie serie)
        {
            _lista.Add(serie);
            TempData["msg"] = "Serie cadastrado com sucesso !";
            return RedirectToAction("Listar");
        }



    }
}