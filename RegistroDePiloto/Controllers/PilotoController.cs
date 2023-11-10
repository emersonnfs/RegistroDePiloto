using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using RegistroDePiloto.Models;
using System.Reflection;
using RegistroDePiloto.Data;

namespace RegistroDePiloto.Controllers
{
    public class PilotoController : Controller
    {
        private readonly PilotoContext _context;

        public PilotoController(PilotoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var pilotos = _context.Pilots.ToList();
            return View(pilotos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Piloto piloto)
        {
            if (ModelState.IsValid)
            {
                _context.Pilots.Add(piloto);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(piloto);
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var piloto = _context.Pilots.Find(id);

            if (piloto == null)
            {
                return NotFound();
            }

            return View(piloto);
        }

        [HttpPost]
        public IActionResult Editar(Piloto piloto)
        {
            var pilotoSalvo = _context.Pilots.Find(piloto.Id);

            if (pilotoSalvo == null)
            {
                return NotFound();
            }

            _context.Entry(pilotoSalvo).CurrentValues.SetValues(piloto);

            if (ModelState.IsValid)
            {
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(piloto);
        }



        [HttpPost]
        public IActionResult Remover(int id)
        {
            var piloto = _context.Pilots.Find(id);
            _context.Pilots.Remove(piloto);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
