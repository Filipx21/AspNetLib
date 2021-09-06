using ControllerActionParameters.Infrastructure;
using ControllerActionParameters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ControllerActionParameters.Controllers
{
    public class HomeController : Controller
    {
        //[HandleError(ExceptionType = typeof(DivideByZeroException), View = "DivideByZeroView")]
        [Timer]
        public ActionResult Index()
        {
            Thread.Sleep(1000);
            //var zero = 0;
            //float f = 2 / zero;

            
            return View();
        }

        public void ParametersBinding(int p1, int p2, int p3, int p4)
        {
            Response.Write(string.Format("p1: {0}, p2: {1}, p3: {2}, p4: {3}", p1, p2, p3, p4));
        }

        #region Parameters binding to class

        public void ParametersBindingToClass(Album a)
        {
            Response.Write(string.Format("Title: {0}, Artist: {1}, Price: {2}", a.AlbumTitle, a.Artist.Name, a.Price));
        }

        #endregion

        #region Action Results

        public ActionResult GoToEdit()
        {
            return RedirectToAction("Edit", "Albums");
        }
        public ActionResult GetFile(string filename)
        {
            var physicalFilePath = Server.MapPath("~/Files/" + filename);
            return File(physicalFilePath, "application/zip");
        }

        public ActionResult GetJson()
        {
            var a = new Album()
            {
                AlbumTitle = "Tytuł albumu",
                Artist = new Artist { Name = "Znany zespół" },
                Price = 29.99m
            };

            return Json(a, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetCsv()
        {          
            return new MyCsvResult("Jan Kowalski" + Environment.NewLine + "Krzysztof Nowak");
        }

        #endregion


    }
}