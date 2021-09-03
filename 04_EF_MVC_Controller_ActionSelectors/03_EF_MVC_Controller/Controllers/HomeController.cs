using SimpleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03_EF_MVC_Controller.Controllers
{
    /* Dostepne rodzaje ActionSelectors:
     * 
     * - [NonAction] - Dana metoda nie bedzie mozliwa do wywolania przez URL
     * - [ActionChange("Nazwa")] - Pozwala zmienić nazwe akcji na inna niż nazwa metody
     * - [AcceptVerbs(HttpVerbs.Post)] - ([HttpPost],[HttpGet]) - Okresla za pomoca jakiego typu żadania ma zostać wywołana akcja
     * 
     */

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Edit(Album album)
        {
            return Content(string.Format("Title: {0}, Artist: {1}", album.AlbumName, album.Artist));
        }

    }
}