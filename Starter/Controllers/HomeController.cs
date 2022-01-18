using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Starter.Models;

namespace Starter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public static string ReadCSVFile()
        {
            using (var reader = new StreamReader("wwwroot/anzeigen.csv"))
            {
                string line = reader.ReadLine();
                return line;
            }
        }

        [HttpPost]
        public IActionResult WriteCSVFile(string p1) /*kere hat geholfen*/ 
        {
            System.IO.File.WriteAllText("wwwroot/anzeigen.csv", p1);
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Passwort()
        {
            return View();
        }
        public IActionResult Tablet()
        {
            return View();
        }

        public IActionResult Steuern()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
