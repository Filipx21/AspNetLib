using _03_EF_MVC_Controller.Infrastructure;
using System.Web;
using System.Web.Mvc;

namespace _03_EF_MVC_Controller
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //dodanie filtru globalnie 
            filters.Add(new TimerAttribute());
        }
    }
}
