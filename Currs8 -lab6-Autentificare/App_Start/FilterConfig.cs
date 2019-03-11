using System.Web;
using System.Web.Mvc;

namespace Currs8__lab6_Autentificare
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
