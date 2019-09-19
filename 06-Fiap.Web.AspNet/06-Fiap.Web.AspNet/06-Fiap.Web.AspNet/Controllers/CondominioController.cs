using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_Fiap.Web.AspNet.Models;
using _06_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class CondominioController : Controller
    {

        private BancoContext _context;

        public CondominioController(BancoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Condominio cond)
        {
            _context.Condominio.Add(cond);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Listar");
        }


        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Condominio.ToList());
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var cond = _context.Condominio.Find(id);
            return View(cond);
        }

        [HttpPost]
        public IActionResult Editar(Condominio cond)
        {
            _context.Condominio.Update(cond);
            _context.SaveChanges();
            TempData["Mensagem"] = "Editado com sucesso";
            return RedirectToAction("Listar");
           
        }


        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var cond = _context.Condominio.Find(id);
            _context.Condominio.Remove(cond);
            _context.SaveChanges();
            TempData["msg"] = "Condominio Excluido!";
            return RedirectToAction("Listar");
        }


     

        [HttpGet]
        public IActionResult Pesquisar(string nome)
        {
            var item = _context.Condominio.Where(p => p.Nome.Contains(nome)).ToList();

            return View("Listar", item);
        }


    }
}