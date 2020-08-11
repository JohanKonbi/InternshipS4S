using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using System.IO;
using System.Net;

namespace InternShipPipeline.Controllers
{
    public class AanmeldenController : Controller
    {
        public static string responseMessage;
        public IActionResult AanMelden()
        {
            return View();
        }

        public ActionResult AanmeldFunctie()
        {
            string n = Request.Form["name"];
            string u = Request.Form["username"];
            string p = Request.Form["password"];
            string i = Request.Form["PID"];
            string e = Request.Form["email"];

            //post request MySQL
            string url = "https://azurefunctioninterships4s.azurewebsites.net/api/AanMelden";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            //post request Cosmos
            /*string cosmosurl = "https://azurefunctioninterships4s.azurewebsites.net/api/AanmeldenCosmos";
            var httpwebRequestCosmos = (HttpWebRequest)WebRequest.Create(cosmosurl);
            httpwebRequestCosmos.ContentType = "application/json";
            httpwebRequestCosmos.Method = "POST";*/


            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //using (var streamWriterCosmos = new StreamWriter(httpwebRequestCosmos.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new 
                    { 
                        username = u,
                        name = n,
                        password = p,
                        id = i,
                        email = e
                    });

                streamWriter.Write(json);
                //streamWriterCosmos.Write(json);
            }

            //get response MySQL
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var streamReader = new StreamReader(httpResponse.GetResponseStream());
            var result = streamReader.ReadToEnd();

            //get response Cosmos
            /*var httpResponseCosmos = (HttpWebResponse)httpwebRequestCosmos.GetResponse();
            var streamReaderCosmos = new StreamReader(httpResponseCosmos.GetResponseStream());
            var resultCosmos = streamReaderCosmos.ReadToEnd();*/

            responseMessage = "MySQl response;" + result; //"Cosmos DB response" + resultCosmos

            return RedirectToAction("AanMelden", "Home");
        }
    }
}
