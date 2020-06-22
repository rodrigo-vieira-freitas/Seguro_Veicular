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
    public class ClienteController : Controller
    {

        private readonly WebSegurosContext _context;

        private WebSegurosContext db = new WebSegurosContext();

        public ClienteController(WebSegurosContext context)
        {
            _context = context;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            return View(db.Cliente.ToList());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,DataNascimento,Cpf,Sexo,EstadoCivil,Celular,Email,Cep,Logradouro,Numero,Bairro,Uf")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                var id = cliente.Id;

                //Calcula idade
                var nascimento = cliente.DataNascimento;
                DateTime dob = Convert.ToDateTime(nascimento);
                int idade = CalculaIdade(dob);

                //Sexo
                var sexo = cliente.Sexo;

                //Estado Civil
                var EstadoCivil = cliente.EstadoCivil;

                return RedirectToAction("Create", "Carros", new { id = id, c = id, i = idade, s = sexo, e = EstadoCivil });
            }
            return View(cliente);
        }

        private static int CalculaIdade(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
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

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
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