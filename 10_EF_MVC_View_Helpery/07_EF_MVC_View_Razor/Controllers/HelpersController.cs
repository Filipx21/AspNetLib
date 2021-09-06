using ControllerActionParameters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerActionParameters.Controllers
{
    public class HelpersController : Controller
    {
        //
        // GET: /Helpers/
        public ActionResult Index()
        {
            var result = new HelpersModel()
            {
                Bool = true,
                DateTime = new DateTime(2000, 08, 15),
                Decimal = 312412431.120m,
                String = "Helpery w ASP.NET MVC!"
            };

            return View(result);
        }
	}
}