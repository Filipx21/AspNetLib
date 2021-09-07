using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Ajax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string GetTime()
        {
            Thread.Sleep(2000);
            return DateTime.Now.ToLongTimeString();
        }


    }
}