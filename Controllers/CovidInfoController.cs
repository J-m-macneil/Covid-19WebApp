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
    public class CovidInfoController : Controller
    {
        private readonly ILogger<CovidInfoController> _logger;

        public CovidInfoController(ILogger<CovidInfoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
