using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
        public IActionResult WriteCSVFile(string p1) 
        {
            System.IO.File.WriteAllText("wwwroot/anzeigen.csv", p1);
            return View("Index");
        }

        [HttpPost]
        public IActionResult CheckPassword(string enteredPassword) 
        {
            string password;
            using (var reader = new StreamReader("wwwroot/passwort.csv"))
            {
                password = reader.ReadLine();
            }
            if (enteredPassword == null)
            {
                return View("Passwort");
            }

            string hash = GetHashString(enteredPassword);
          


            
            if (hash == password)
            {
                return View("Steuern");
                
            }
            else
            {
                return View("Passwort");
            }


            
        }
        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }
        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
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
