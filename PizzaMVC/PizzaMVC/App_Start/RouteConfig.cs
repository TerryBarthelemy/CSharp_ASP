using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PizzaMVC
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute("Contact", "Contact", new { controller = "Home", action = "Contact" });
			routes.MapRoute("About", "About", new { controller = "Home", action = "About" });
			routes.MapRoute("ListofPizzas", "ListofPizzas", new { controller = "Pizza", action = "ListofPizzas" });
			routes.MapRoute("Index", "Index", new { controller = "PizzaCRUD", action = "Pizza DB" });

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
