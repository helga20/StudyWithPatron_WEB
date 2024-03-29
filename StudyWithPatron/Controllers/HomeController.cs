﻿using Microsoft.AspNetCore.Mvc;
using StudyWithPatron.Models;
using System.Diagnostics;

namespace StudyWithPatron.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult AddSubt()
        {
            return View();
        }
        public IActionResult MultDiv()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Saper()
        {
            return View();
        }
        public IActionResult Rating()
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