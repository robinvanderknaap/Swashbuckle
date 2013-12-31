using System.Web.Optimization;

namespace Swashbuckle.TestApp.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Bundles/Swagger").Include
            (
                "~/Scripts/shred.bundle.js",
                "~/Scripts/jquery-1.8.0.min.js",
                "~/Scripts/jquery.slideto.min.js",
                "~/Scripts/jquery.wiggle.min.js",
                "~/Scripts/jquery.ba-bbq.min.js",
                "~/Scripts/handlebars-1.0.0.js",
                "~/Scripts/underscore-min.js",
                "~/Scripts/backbone-min.js",
                "~/Scripts/swagger.js",
                "~/Scripts/swagger-ui.js",
                "~/Scripts/highlight.7.3.pack.js"
            ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/highlight.default.css",
                "~/Content/screen.css"
            ));
        }
    }
}
