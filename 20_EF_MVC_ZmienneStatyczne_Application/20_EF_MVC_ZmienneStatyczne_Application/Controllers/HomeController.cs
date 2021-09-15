using _20_EF_MVC_ZmienneStatyczne_Application.Models;
using System.Web.Mvc;

namespace InfrastructureAndState.Controllers
{
    public class HomeController : Controller
    {
        private object staticCounterLock = new object();

        public ActionResult Index(int id = 1)
        {
            var counters = GetCounters();
            return View(counters);
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
            counters.ApplicationCounter++; // Inkrementuj stan zapisany w Application[]
            SetCounters(counters);
            HttpContext.Application.UnLock();

            return RedirectToAction("Index");
        }

        private Counters GetCounters()
        {
            var counters = new Counters();
            if (HttpContext.Application["counter"] != null)
            {
                counters.ApplicationCounter = (int)HttpContext.Application["counter"];
            }
            else
            {
                counters.ApplicationCounter = 0;
            }
           
            return counters;
        }

        private void SetCounters(Counters counters)
        {
            HttpContext.Application["counter"] = counters.ApplicationCounter;

        }

    }
}