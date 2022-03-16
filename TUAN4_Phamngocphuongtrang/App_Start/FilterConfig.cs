using System.Web;
using System.Web.Mvc;

namespace TUAN4_Phamngocphuongtrang
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
