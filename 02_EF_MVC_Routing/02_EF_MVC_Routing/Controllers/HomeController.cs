using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_EF_MVC_Routing.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }

        //Atak XSS
        //public string Index()
        //{
        //    return "<script>console.log('test')</script>";
        //}

        //Aby uniknąć XSS
        //public string Index()
        //{
        //    return Server.HtmlEncode("<script>console.log('test')</script>");
        //}
    }
}