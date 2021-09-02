using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _02_EF_MVC_Routing.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    var result = "";
        //    foreach(var routeKey in RouteData.Values.Keys)
        //    {
        //        result += "Key: " + routeKey + ", Value: " + RouteData.Values[routeKey] as string;
        //        result += "<br/>";
        //    }
        //    return result;
        //}

        //Wsteczny routing
        public string Index()
        {
            var path = RouteTable.Routes.GetVirtualPath(null, new RouteValueDictionary(new { Controller = "Kontroler", Action = "Akcja", Id="12", Param="Lipton"}));
            var result = path.VirtualPath;
            return result;
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