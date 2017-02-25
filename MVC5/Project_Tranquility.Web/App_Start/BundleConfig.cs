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
                "~/wwwroot/lib/bootstrap/dist/js/bootstrap.js"));

            //Styling
            bundles.Add(new StyleBundle("~/wwwroot/css").Include(
                "~/wwwroot/lib/bootstrap/dist/css/bootstrap.css",
                "~/wwwroot/css/Site.css"));
        }
    }
}
