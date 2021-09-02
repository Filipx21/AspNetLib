using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _02_EF_MVC_Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ProductDetails",
                url: "album-{id}.html",
                defaults: new { controller = "Store", action = "Details" }
            );

            routes.MapRoute(
                name: "ProductList",
                url: "gatunki/{genrename}",
                defaults: new { controller = "Store", action = "List" },
                constraints: new { genrename = @"[\w& ]+" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
