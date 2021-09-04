using _06_EF_MVC_View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06_EF_MVC_View.Controllers
{
    public class HomeController : Controller
    {     
        public ActionResult Index()
        {
            //ViewBag.Message = "Witaj, świecie";
            var vm = new SampleViewModel { Message = "Witaj, świecie!" };
             
            return View(vm);
        }

	}
}