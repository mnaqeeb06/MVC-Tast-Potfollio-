using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Task
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "SignUp", action = "signupView", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "login",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "LogIn", action = "loginView", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "potfollio",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "potfillio", action = "potfollioView", id = UrlParameter.Optional }
            );
        }
    }
}
