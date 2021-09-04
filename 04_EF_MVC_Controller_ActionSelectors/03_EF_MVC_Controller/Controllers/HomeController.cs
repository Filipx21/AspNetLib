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
     * - HandleError - okreslenie widoku do zwrócenia w razie bledu;Aby uruchomic wylapywanie bledów trzeba dodac <customErrors mode="On" defaultRedirect="Error.html"/> do web config
     * - OutputCache - Zapisz odpowiedz w cache
     * - ValidateInput - Wyłaczenie walidowania danych wejsciowych do danej akcji
     * - ValidateAntiForgeryToken - zabezpieczenie przez atakie CSRF
     */

    public class HomeController : Controller
    {
        //[Authorize]
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //Wyswietlenie wlasnej strony z errorem po wczesniejszym uruchomieniu wyswietlania błedów; Patrz wyżej
        [HandleError(ExceptionType = typeof(DivideByZeroException), View = "NewError")]
        public ActionResult Index()
        {
            var zero = 0;
            double result = 2 / zero;
            return View();
        }


    }
}