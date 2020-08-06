using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace InternShipPipeline.Controllers
{
    public class WerkgeverController : Controller
    {
        public static string responseMessage;
        public IActionResult Werkgever()
        {
            return View();
        }

        //functies voor database gegevens opvragen
    }
}
