using System.Web;
using System.Web.Mvc;

namespace http_5101_Assignment1_AlbyBaby_n01462455
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
