using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;

namespace InternShipPipeline.Controllers
{
    public class LoginController : Controller
    {
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

            System.IO.StreamReader file = new System.IO.StreamReader(@".\Views\Login\LoginData.txt");
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

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        /*
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
