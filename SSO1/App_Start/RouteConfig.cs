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
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "LoginPage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "GetUsers",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "GetListUsers", id = UrlParameter.Optional }

                );


            routes.MapRoute(
                name: "test",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "PostData",
                url: "{ controller}/{ action}/{ id}",
                //url: "Ajouter/{valeur1}/{valeur2}",
                defaults: new { controller = "Main", action = "postUser" });
        }


    }
}