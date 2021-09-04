using _07_EF_MVC_View_Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_EF_MVC_View_Razor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Course> courses = new List<Course>
            {
                new Course() { Name = "Responsive Web Design", Description = "Kurs na temat technik tworzenia stron zgodnie z założeniami Responsive Web Design", ImageUrl = "http://eduweb.pl/Images/Training/medium_3dc7546f-07f9-419f-b9b1-c16a27ed5d59.png" },
                new Course() { Name = "Preprocesory CSS", Description = "Obejrzyj, jeśli chcesz poznać SASS, LESS i inne.", ImageUrl = "http://eduweb.pl/Images/Training/medium_9b400ab6-febe-4abd-9738-1c175f3b8802.png" },
                new Course() { Name = "WordPress", Description = "Wiele wiedzy na temat popularnego systemu CMS", ImageUrl = "http://eduweb.pl/Images/Training/medium_pluginy_06486687-2821-4151-9730-d6df7b9b2eef.png" }
            };

            return View(courses);
        }

    }
}