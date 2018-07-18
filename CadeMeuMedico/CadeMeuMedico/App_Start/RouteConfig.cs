using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CadeMeuMedico
{
    public class RouteConfig
    {
        // Alterando a rota padrão...
        public static void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Mobile",
                "Mobile/{controller}/{action}/{id}",
                new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }

        // Dando prioridade para o controller de desktop.
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );*/
            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                },
                // Adicione o namespace dos controladores desktop a seguir.
                new[] { "CadeMeuMedico.Controllers" }
            );
        }
    }
}
