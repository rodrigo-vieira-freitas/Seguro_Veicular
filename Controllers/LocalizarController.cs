using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSeguros.Context;

namespace WebSeguros.Controllers
{
    public class LocalizarController : Controller
    {
        private readonly WebSegurosContext _context;

        //private WebSegurosContext db = new WebSegurosContext();

        public LocalizarController(WebSegurosContext context)
        {
            _context = context;
        }

        // GET: Localizar
        public ActionResult Index()
        {
            return View();
        }

        // GET: Localizar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Localizar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Localizar/Create
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

        // GET: Localizar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Localizar/Edit/5
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

        // GET: Localizar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Localizar/Delete/5
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