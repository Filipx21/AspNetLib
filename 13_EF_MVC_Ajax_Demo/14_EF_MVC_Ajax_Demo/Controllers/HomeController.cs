using Demo.DAL;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly PersonContext context = new PersonContext();

        public ActionResult Index(string searchQuery = null)
        {
            IEnumerable<Person> personList;

            if (searchQuery != null)
                personList = context.Persons
                    .Where(p => p.FirstName.Contains(searchQuery) 
                        || p.LastName.Contains(searchQuery) 
                        || p.FirstName + " " + p.LastName == searchQuery)
                    .ToArray();
            else
                personList = context.Persons.ToArray();

            if (Request.IsAjaxRequest())
            {
                return PartialView("_PersonListPartialView", personList);
            }

            return View(personList);
        }

        public ActionResult PersonSuggestions(string term)
        {
            var personList = context.Persons
                .Where(p => p.FirstName.Contains(term) 
                    || p.LastName.Contains(term))
                .Take(5)
                .Select(p => new { label = p.FirstName + " " + p.LastName });

            return Json(personList, JsonRequestBehavior.AllowGet);
        }

    }
}