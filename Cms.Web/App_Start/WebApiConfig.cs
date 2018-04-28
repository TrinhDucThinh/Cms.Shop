using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Cms.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.Routes.MapHttpRoute(
            //    name: "",
            //    routeTemplate: "api/v1/places/{category}/{region}/{area}/{page}/{count}",
            //    defaults: new { controller = "Items", keyword = "", category = 0, region = 0, area = 0, page = 0, count = 0 }
            //);
        }
    }
}
