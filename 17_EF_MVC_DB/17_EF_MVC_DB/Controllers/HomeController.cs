using _17_EF_MVC_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17_EF_MVC_DB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddQuestion(Question question)
        {
            if (question.QuestionText == "?")
                ModelState.AddModelError("QuestionText", "Komunikat dodany manualnie. Nie może być samego znaku zapytania...");

            if (!ModelState.IsValid)
                return View("Index", question);
            else
            {
                // Kod zapisujący lub wysyłający pytanie do właściciela strony

                return View("Index");
            }
        }

	}
}