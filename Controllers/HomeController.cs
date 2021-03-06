﻿using System;
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

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    
        public IActionResult Submit(Ninja thisNinja)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success", thisNinja);
            }
            else
            {
                return View("resubmit", thisNinja);
            }
        }

        public IActionResult Success(Ninja thisNinja)
        {
            ViewData["Message"] = "Thanks for submitting.";

            return View("submitted", thisNinja);
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
