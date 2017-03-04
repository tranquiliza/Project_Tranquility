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
            bundles.Add(new ScriptBundle("~/bundle/js")
                .Include("~/wwwroot/lib/jquery/dist/jquery.js")
                .Include("~/wwwroot/lib/materialize/dist/js/materialize.min.js")
            );

            //Styling
            bundles.Add(new StyleBundle("~/bundle/css")
                .Include("~/wwwroot/lib/materialize/dist/css/materialize.min.css", new CssRewriteUrlTransform())
                .Include("~/wwwroot/css/site.css")
            );
        }
    }
}
