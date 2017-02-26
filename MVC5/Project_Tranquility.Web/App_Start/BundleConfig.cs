using System.Web;
using System.Web.Optimization;

namespace Project_Tranquility.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Scripts
            bundles.Add(new ScriptBundle("~/wwwroot/js").Include(
                "~/wwwroot/lib/jquery/dist/jquery.js",
                "~/wwwroot/lib/bootstrap/dist/js/bootstrap.js",
                "~/wwwroot/lib/metisMenu/dist/metisMenu.js",
                "~/wwwroot/js/sb-admin-2.js"));

            //Styling
            bundles.Add(new StyleBundle("~/wwwroot/css").Include(
                "~/wwwroot/lib/bootstrap/dist/css/bootstrap.css",
                "~/wwwroot/lib/font-awesome/css/font-awesome.css",
                "~/wwwroot/lib/metisMenu/dist/metisMenu.css",
                "~/wwwroot/css/sb-admin-2.css",
                "~/wwwroot/css/Site.css"));
        }
    }
}
