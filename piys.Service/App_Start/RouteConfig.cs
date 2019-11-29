using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bitirme_Service
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "Default/{controller}/{action}/{ID}",
                defaults: new { action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Login",
                url: "Login/{controller}/{action}/{userid},{userpassword}",
                defaults: new { action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Teacher",
                url: "Teacher/{controller}/{action}/{ID}",
                defaults: new { action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "inspection",
                url: "inspection/{controller}/{action}/{lessonid}_{fid}_{day}_{week}_{firsth}_{lasth}",
                defaults: new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

