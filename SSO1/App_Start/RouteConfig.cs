using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SSO1
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "ListUsers", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "sso",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "LoginPage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "WebApp1",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "WebApp1", id = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "WebApp2",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "WebApp2", id = UrlParameter.Optional }
            );


            //routes.MapRoute(
            //    name: "PostData",
            //    url: "{ controller}/{ action}/{ id}",
            //    //url: "Ajouter/{valeur1}/{valeur2}",
            //    defaults: new { controller = "Main", action = "postUser" });
        }


    }
}