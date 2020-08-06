using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using MySqlX.XDevAPI;
using Nancy.Json;
using System.Net;
using System.IO;

namespace InternShipPipeline.Controllers
{
    public class LoginController : Controller
    {
        public static string responseMessage;
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Check()
        {
            string line;
            var username = Request.Form["username"];
            var password = Request.Form["password"];

            System.IO.StreamReader file = new System.IO.StreamReader(@"D:\home\site\wwwroot\LoginData.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line == username + " " + password)
                {
                    HomeController.username = username;
                    return RedirectToAction("Clock", "Home");
                }
            }
            return Content("Username and/or password are incorrect"); //RedirectToAction("Privacy", "Home"); 
        }

        public ActionResult LoginFunctie()
        {
            string u = Request.Form["username"];
            string p = Request.Form["password"];

            //post request
            string url = "https://azurefunctioninterships4s.azurewebsites.net/api/Inloggen";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    username = u,
                    password = p
                });

                streamWriter.Write(json);
            }

            //get response
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var streamReader = new StreamReader(httpResponse.GetResponseStream());
            var result = streamReader.ReadToEnd();

            responseMessage = result;

            return RedirectToAction("Index", "Home");
        }

        /*public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public class CheckLogin
        {
            public void ToFile()
            {
                var userlist = new List<User>();
                userlist.Add(new User { Username = "amy", Password = "1234" });

                System.IO.StreamWriter file = new System.IO.StreamWriter(@"..\LoginData.tx");

                foreach (User s in userlist)
                {
                    file.WriteLine(s.Username + " " + s.Password);
                }
            }
        }*/
    }
}
