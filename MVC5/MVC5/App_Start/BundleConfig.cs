using System.Web;
using System.Web.Optimization;

namespace MVC5
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/wwwroot/lib/jquery/dist/jquery.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/wwwroot/lib/bootstrap/dist/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/wwwroot/lib/bootstrap/dist/css/bootstrap-theme.css",
                      "~/wwwroot/lib/bootstrap/dist/css/bootstrap.css",
                      "~/wwwroot/lib/font-awesome/css/font-awesome.css",
                      "~/wwwroot/css/Site.css"));
        }
    }
}
