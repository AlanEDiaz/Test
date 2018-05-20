using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApiRestfull
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "MyRestfullApp/Cotizacion/MONEDA/{currency}",
                defaults: new { controller = "WebApiHome", action = "GetQuotation", id = UrlParameter.Optional}
            );
        }
    }
}
