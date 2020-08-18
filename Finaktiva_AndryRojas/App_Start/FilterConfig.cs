using System.Web;
using System.Web.Mvc;

namespace Finaktiva_AndryRojas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
