using MyValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyValidation.Controllers
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