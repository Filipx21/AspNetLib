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

        [HttpPost]
        public ActionResult IncrementSession()
        {
            var counters = GetCounters();

            // Inkrementuj stan zapisany w Session[]
            counters.SessionCounter++;

            SetCounters(counters);

            return RedirectToAction("Index");
        }

        private Counters GetCounters()
        {
            var counters = new Counters();

            if (Session["counter"] != null)
            {
                counters.SessionCounter = (int)Session["counter"];
            }
            else
            {
                counters.SessionCounter = 0;
            }

            return counters;
        }

        private void SetCounters(Counters counters)
        {
            Session["counter"] = counters.SessionCounter;
        }

    }
}