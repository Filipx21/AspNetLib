using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_EF_MVC_Security.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize(Users = "NotExistingUser")] // <- Pozwala na dostep dla okreslonych userów
        //[Authorize(Roles = "Admin")] // <- Dostep do danych dla danej grupy 
        public ActionResult Index()
        {
            //var role1check = User.IsInRole("Users");// <- Pozwala na dostep dla okreslonych userów; Zwraca bool
            //var role2check = User.IsInRole("TEST/TEST");

            if (User.Identity.IsAuthenticated) // <- Sprawdza czy user jest zalogowany; Return bool
            { 
            
            } 
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}