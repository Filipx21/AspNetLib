using SimpleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var albums = new List<Album>
            {
                new Album() { Id=1, Artist="Test", AlbumName="Testowanie"},
                new Album() { Id=2, Artist="Coldplay", AlbumName="Mylo Xyloto"}
            };
            return View(albums);
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