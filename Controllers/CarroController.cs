using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSeguros.Context;
using WebSeguros.Models;

namespace WebSeguros.Controllers
{
    public class CarroController : Controller
    {
        private readonly WebSegurosContext _context;

        private WebSegurosContext db = new WebSegurosContext();

        public CarroController(WebSegurosContext context)
        {
            _context = context;
        }

        // GET: Carro
        public ActionResult Index()
        {
            return View();
        }

        // GET: Carro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Carro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Carro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TrabalhaVei,Garagem,TipoSeguro,Marca,Modelo,Ano,Placa,Cor,ValorVeiculo,ValorSeguro,IdCliente")] Carro carro)
        {

            if (ModelState.IsValid)
            {
                _context.Add(carro);
                await _context.SaveChangesAsync();
                //PARTE 2 - DESATIVADO
                return Redirect("https://automlsite.firebaseapp.com/?s=1");

            }

            return View();


        }

        // GET: Carro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Carro/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Carro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Carro/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}