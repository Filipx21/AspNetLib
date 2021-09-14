using DevTrends.MvcDonutCaching;
using InfrastructureAndState.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace InfrastructureAndState.Controllers
{
    public class HomeController : Controller
    {
        private object staticCounterLock = new object();

        //[DonutOutputCache(Duration=10, VaryByParam="none")]
        public ActionResult Index(int id = 1)
        {
            var counters = GetCounters();
            return View(counters);
        }

        //[DonutOutputCache(Duration = 5, VaryByParam = "none")]
        //[OutputCache(Duration=5)]
        [ChildActionOnly]
        public string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }

        public ActionResult PRGDemo()
        {
            ViewBag.TempParam = TempData["param"];

            return View();
        }

        [HttpPost]
        public ActionResult PassTempData(string paramtopass)
        {
            TempData["param"] = paramtopass;

            return RedirectToAction("PRGDemo");

            //ViewBag.TempParam = paramtopass;
            //return View("PRGDemo");
        }

        [HttpPost]
        public ActionResult IncrementStatic()
        {
            lock (staticCounterLock)
            {
                var counters = GetCounters();

                // Inkrementuj statyczne pole
                counters.StaticCounter++;
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult IncrementApplication()
        {
            HttpContext.Application.Lock();

            var counters = GetCounters();

            // Inkrementuj stan zapisany w Application[]
            counters.ApplicationCounter++;

            SetCounters(counters);

            HttpContext.Application.UnLock();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult IncrementSession()
        {
            var counters = GetCounters();

            // Inkrementuj stan zapisany w Session[]
            counters.SessionCounter++;

            SetCounters(counters);

            return RedirectToAction("Index");
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

        [HttpPost]
        public ActionResult IncrementCache()
        {
            var counters = GetCounters();

            // Inkrementuj stan zapisany w Cache
            counters.CacheCounter++;

            SetCounters(counters);

            return RedirectToAction("Index");
        }


        private Counters GetCounters()
        {
            var counters = new Counters();

            // Application
            if (HttpContext.Application["counter"] != null)
            {
                counters.ApplicationCounter = (int)HttpContext.Application["counter"];
            }
            else
            {
                counters.ApplicationCounter = 0;
            }

            // Sesja
            if (Session["counter"] != null)
            {
                counters.SessionCounter = (int)Session["counter"];
            }
            else
            {
                counters.SessionCounter = 0;
            }

            // Cookie
            if (Request.Cookies["counter"] != null)
            {
                counters.CookieCounter = int.Parse(Request.Cookies["counter"].Value);
            }
            else
            {
                counters.CookieCounter = 0;
            }

            // Cache
            if (HttpRuntime.Cache["counter"] != null)
            {
                counters.CacheCounter = (int)HttpRuntime.Cache["counter"];
            }
            else
            {
                counters.CacheCounter = 0;
            }

            return counters;
        }

        private void SetCounters(Counters counters)
        {
            HttpContext.Application["counter"] = counters.ApplicationCounter;
            Session["counter"] = counters.SessionCounter;

            HttpCookie cookie = new HttpCookie("counter", counters.CookieCounter.ToString());
            //cookie.Expires = DateTime.Now.AddDays(-1);
            //cookie.Expires = DateTime.Now.AddDays(1);
            Response.SetCookie(cookie);

            //HttpRuntime.Cache.Remove("counter");
            //HttpRuntime.Cache.Add("counter", counters.CacheCounter, null, DateTime.Now.AddSeconds(5), TimeSpan.Zero, CacheItemPriority.Default, null);
            HttpRuntime.Cache["counter"] = counters.CacheCounter;
        }
    }
}