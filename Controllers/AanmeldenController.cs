using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net;
using System.IO;

namespace InternShipPipeline.Controllers
{
    public class AanmeldenController : Controller
    {
        public IActionResult AanMelden()
        {
            return View();
        }

        public ActionResult AanmeldFunctie()
        {
            //post request
            string url = "https://azurefunctioninterships4s.azurewebsites.net/api/AanMelden";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"name\":\"test\"}";
                streamWriter.Write(json);
            }

            //get response
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var streamReader = new StreamReader(httpResponse.GetResponseStream());
            var result = streamReader.ReadToEnd();
            
            return Content(result);
        }
    }
}
