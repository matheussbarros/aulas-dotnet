using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _05_Fiap.Web.AspNet.Models;
using _05_Fiap.Web.AspNet.Percistences;
using Microsoft.EntityFrameworkCore;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class SerieController : Controller
    {

        private BancoContext _context;

    

        public SerieController(BancoContext context)
        {
            _context = context;
        }

        //private static IList<Serie> _lista = new List<Serie>();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Series.ToList());
        }


        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }


        public IActionResult Cadastrar (Serie serie)
        {
            _context.Series.Add(serie);
            _context.SaveChanges();
            TempData["msg"] = "Serie cadastrado com sucesso !";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var serie = _context.Series.Find(id);
            return View(serie);
        }

        [HttpPost]
        public IActionResult Editar(Serie serie)
        {

            _context.Attach(serie).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Atualizado!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var serie = _context.Series.Find(id);
            _context.Series.Remove(serie);
            _context.SaveChanges();
            TempData["msg"] = "Serie Deletada!";
            return RedirectToAction("Listar");
        }





    }
}