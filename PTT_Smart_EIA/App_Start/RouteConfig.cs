﻿using System.Web.Mvc;
using System.Web.Routing;

namespace PTT_Smart_EIA
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "SmartEIA", action = "Login", id = UrlParameter.Optional }
            );

          
        }
    }
    
}
