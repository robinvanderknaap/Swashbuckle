using System;
using System.IO;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using Swashbuckle.Models;

namespace Swashbuckle.TestApp.App_Start
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

            SwaggerSpecConfig.Customize(c =>
            {
                c.ApiVersion = "1.1";
            });

            try
            {
                config.Services.Replace(typeof(IDocumentationProvider), new XmlCommentDocumentationProvider(
                    HttpContext.Current.Server.MapPath("~/bin/Swashbuckle.TestApp.XML")));
            }
            catch (FileNotFoundException)
            {
                throw new Exception("Please enable \"XML documentation file\" in project properties with default (bin\\Swashbuckle.TestApp.XML) value or edit value in App_Start\\Swashbuckle.WebApiConfig.cs");
            }
        }
    }
}
