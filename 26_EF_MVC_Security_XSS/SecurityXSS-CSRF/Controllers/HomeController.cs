using Microsoft.Security.Application;
using SecurityXSS_CSRF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityXSS_CSRF.Controllers
{
    public class HomeController : Controller
    {
        private static List<Question> Questions { get; set; }

        static HomeController()
        {
            HomeController.Questions = new List<Question>();
        }

        public ActionResult Index()
        {
            return View(HomeController.Questions);
        }

        [ValidateInput(false)] // Wylaczenie weryfikacji dla np. wprowadzania HTML
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddQuestion(Question newQuestion)
        {
            //newQuestion.QuestionText = Sanitizer.GetSafeHtmlFragment(newQuestion.QuestionText); // <- AntiXSS
            
            HomeController.Questions.Add(newQuestion);
            return RedirectToAction("Index");
        }

	}
}