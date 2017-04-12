using System.Web;
using System.Web.Mvc;

namespace GEC6.Blog.Yan.Solution.WebBlogMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
