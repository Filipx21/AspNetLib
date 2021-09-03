using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03_EF_MVC_Controller.Controllers
{
    /* Dostepne rodzaje ActionResult
     * - EmptyResult - Brak odpowiedzi; Wykorzyststywane gdy akcja zrwaca null or void
     * - ContentResult - Odpowiedz jako tekst; Wykorzystywane gdy akcja zwraca inny typ niż ActionResult(string, int)
     * - JsonResult - Serializuje obiekt do JSON;
     * - RedirectResult - Przekierowywuje do URL
     * - RedirectToRouteResult - Przekierowuje na podstawie routingu
     * - ViewResult - Uruchamia renderowanie przez ViewEngine
     * - PartialViewResult - Wysyła czesc widoku; Wykorzystywane np. do AJAX
     * - FileContentResult, FilePathResult, FileStreamResult - Zwraca plik
     * - JavaScriptResult - Wysyła i wywołuje JS po stronie klienta
     */

    public class HomeController : Controller
    {
        public ActionResult ProductsList()
        {
            IList<string> products = Test();
            return View(products);
        }




        public List<string> Test()
        {
            return new List<string>()
            {
                "1",
                "2",
                "3",
                "4"
            };
        }
    }
}