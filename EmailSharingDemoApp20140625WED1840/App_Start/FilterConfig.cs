using System.Web;
using System.Web.Mvc;

namespace EmailSharingDemoApp20140625WED1840
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
