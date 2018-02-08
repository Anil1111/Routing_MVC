﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Anasayfa",
                url: "Anasayfa",
                defaults: new { Controller = "Home", Action = "Index" }
                );

            routes.MapRoute(
                name: "İletişim",
                url: "İletişim",
                defaults: new { Controller = "Home", Action = "Contact" }
                );

            routes.MapRoute(
                name: "Hakkında",
                url: "Hakkında",
                defaults: new { Controller = "Home", Action = "About" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
