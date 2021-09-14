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

        private Counters GetCounters()
        {
            var counters = new Counters();
            return counters;
        }

        
    }
}