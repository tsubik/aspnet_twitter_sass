using System.Web;
using System.Web.Mvc;

namespace Aspnet_twitter_sass
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}