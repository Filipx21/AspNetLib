using System.Web;
using System.Web.Mvc;

namespace _14_EF_MVC_Model
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
