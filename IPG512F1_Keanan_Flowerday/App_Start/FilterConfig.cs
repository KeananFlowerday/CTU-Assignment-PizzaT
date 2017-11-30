using System.Web;
using System.Web.Mvc;

namespace IPG512F1_Keanan_Flowerday
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
			//filters.Add(new AuthorizeAttribute());
		}
	}
}
