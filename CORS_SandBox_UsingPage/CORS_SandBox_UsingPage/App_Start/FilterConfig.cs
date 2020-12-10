using System.Web;
using System.Web.Mvc;

namespace CORS_SandBox_UsingPage
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
