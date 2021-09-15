using _20_EF_MVC_ZmienneStatyczne_Application.Models;
using System;
using System.Web;
using System.Web.Mvc;

namespace InfrastructureAndState.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id = 1)
        {
            var counters = GetCounters();
            return View(counters);
        }

        [HttpPost]
        public ActionResult IncrementCookies()
        {
            var counters = GetCounters();

            // Inkrementuj stan zapisany w Cookie
            counters.CookieCounter++;

            SetCounters(counters);

            return RedirectToAction("Index");
        }

        private Counters GetCounters()
        {
            var counters = new Counters();

            // Cookie
            if (Request.Cookies["counter"] != null)
            {
                counters.CookieCounter = int.Parse(Request.Cookies["counter"].Value);
            }
            else
            {
                counters.CookieCounter = 0;
            }

            return counters;
        }

        private void SetCounters(Counters counters)
        {
            HttpCookie cookie = new HttpCookie("counter", counters.CookieCounter.ToString());
            //cookie.Expires = DateTime.Now.AddDays(-1);
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.SetCookie(cookie);
        }

    }
}