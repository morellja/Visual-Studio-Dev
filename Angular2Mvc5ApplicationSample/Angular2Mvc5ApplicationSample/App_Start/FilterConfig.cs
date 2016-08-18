using System.Web;
using System.Web.Mvc;

namespace Angular2Mvc5ApplicationSample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
