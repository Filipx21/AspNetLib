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
     * - Authorize - tylko dla uwierzytelnionych, okreslonych użytkowników
     * - HandleError - okreslenie widoku do zwrócenia w razie bledu
     * - OutputCache - Zapisz odpowiedz w cache
     * - ValidateInput - Wyłaczenie walidowania danych wejsciowych do danej akcji
     * - ValidateAntiForgeryToken - zabezpieczenie przez atakie CSRF
     */

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        

    }
}