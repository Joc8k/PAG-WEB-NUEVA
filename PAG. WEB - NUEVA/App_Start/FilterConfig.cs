using System.Web;
using System.Web.Mvc;

namespace PAG.WEB___NUEVA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
