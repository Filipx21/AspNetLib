using System.Web;
using System.Web.Mvc;

namespace _19_EF_MCV_Temp_Data
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
