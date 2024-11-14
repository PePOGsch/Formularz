using Formularz.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Formularz.Controllers
{
    public class DaneController : Controller
    {

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            return View("Wynik", dane); // Przekierowanie do widoku Wynik z danymi
        }

        public IActionResult Wynik(Dane dane)
        {
            return View(dane);
        }

        // GET: DaneController
        public ActionResult Index()
        {
            return View(Form());
        }

        // GET: DaneController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DaneController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DaneController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DaneController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DaneController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DaneController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DaneController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
