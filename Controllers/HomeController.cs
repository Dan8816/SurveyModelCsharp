using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Survey.Models;

namespace Survey.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("index");
        }

        [HttpPost]     
        [Route("/submit")]    
        public IActionResult Submit(string Name, string Location, string Language, string Comment)
        {
            ViewData["Message"] = "Thanks you for you submitted data!";
            Ninja thisNinja = new Ninja()
            {
                Name = Name,
                Location = Location,
                Language = Language,
                Comment = Comment,
            };
            return View(thisNinja);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View("submit");
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
