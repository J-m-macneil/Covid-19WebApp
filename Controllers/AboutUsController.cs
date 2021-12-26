using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProjectWebApp.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly ILogger<AboutUsController> _logger;

        public AboutUsController(ILogger<AboutUsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
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
