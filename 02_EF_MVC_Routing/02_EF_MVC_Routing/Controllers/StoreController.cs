using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_EF_MVC_Routing.Controllers
{
    [RoutePrefix("prefiks")]
    public class StoreController : Controller
    {
        // 2 podejscie do routów, trzeba dodac wpis w configu
        [Route("to/jest/{moja}/trasa")]
        public string Index(string moja)
        {
            return "Attribute routing: " + moja;
        }

        [Route("{param:int}")]
        public string Attr(string param)
        {
            return param;
        }
    }
}