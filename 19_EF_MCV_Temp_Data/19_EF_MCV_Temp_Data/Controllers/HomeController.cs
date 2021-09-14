using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19_EF_MCV_Temp_Data.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PassTempData(string paramtopass)
        {
            TempData["param"] = paramtopass;

            return RedirectToAction("PRGDemo");
        }

        public ActionResult PRGDemo()
        {
            ViewBag.TempParam = TempData["param"];

            return View("PRGDemo");
        }

    }
}