using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InternShipPipeline.Controllers
{
    public class WerknemerController : Controller
    {
        public IActionResult Werknemer()
        {
            return View();
        }

    }
}
