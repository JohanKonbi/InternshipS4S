using InternShipPipeline.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Data.SqlClient;
using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace InternShipPipeline.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        public static string username;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Inloggen()
        {
            return View();
        }

        public IActionResult Werkgever()
        {
            return View();
        }
        public IActionResult Werknemer()
        {
            return View();
        }

        public IActionResult AanMelden()
        {
            ViewBag.Message = "Aanmeldpagina";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
