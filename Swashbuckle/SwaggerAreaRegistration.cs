using System.Web.Mvc;

namespace Swashbuckle
{
    public class SwaggerAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return "Swagger"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.Routes.MapRoute(
                "swagger_declaration",
                "swagger/api-docs/{resourceName}",
                new { controller = "ApiDocs", action = "Show" });

            context.Routes.MapRoute(
                "swagger_listing",
                "swagger/api-docs",
                new {controller = "ApiDocs", action = "Index"});
        }
    }
}