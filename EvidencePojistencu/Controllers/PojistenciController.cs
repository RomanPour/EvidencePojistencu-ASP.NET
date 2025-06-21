using Microsoft.AspNetCore.Mvc;
using EvidencePojistencu.Models;
using EvidencePojistencu.Services;

namespace EvidencePojistencu.Controllers
{
    public class PojistenciController : Controller
    {
        private readonly DatabazeService _databaze;

        public PojistenciController(DatabazeService databaze)
        {
            _databaze = databaze;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Pridej()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Pridej(Pojistenec p)
        {
            if (ModelState.IsValid)
            {
                _databaze.Pridej(p);
                return RedirectToAction("Vypis");
            }
            return View(p);
        }

        public IActionResult Vypis()
        {
            var seznam = _databaze.VratVsechny();
            return View(seznam);
        }

        [HttpGet]
        public IActionResult Najdi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Najdi(string jmeno, string prijmeni)
        {
            var nalezeny = _databaze.Najdi(jmeno, prijmeni);
            return View("Detail", nalezeny);
        }

        public IActionResult Detail(Pojistenec? p)
        {
            return View(p);
        }
    }
}
