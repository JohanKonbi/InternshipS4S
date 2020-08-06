using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using System.IO;
using System.Net;

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
            string n = Request.Form["username"];
            string p = Request.Form["password"];
            string i = Request.Form["PID"];
            string e = Request.Form["email"];

            //post request
            string url = "https://azurefunctioninterships4s.azurewebsites.net/api/AanMelden";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new 
                    { 
                        name = n,
                        password = p,
                        id = i,
                        email = e
                    });

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
