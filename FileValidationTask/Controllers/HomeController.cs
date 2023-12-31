﻿using FileValidationTask.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FileValidationTask.Controllers
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

        [HttpPost]
        public IActionResult Index(FileModel file)
        {
            if (ModelState.IsValid)
            {
                TempData["SuccessMessage"] = "File has been successfully uploaded!";
            }

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