﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EasyScheduleWebClient
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Login",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "EasyScheduleWebClient.Controllers" }
            );

            routes.MapRoute(
                name: "ViewAllAvailableShifts",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "AvailableShifts", action = "Index", id = UrlParameter.Optional},
                namespaces: new[] { "EasyScheduleWebClient.Controllers" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }, namespaces: new[] { "EasyScheduleWebClient.Controllers" }

            );
            
        }
    }
}
