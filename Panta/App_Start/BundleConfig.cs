using System.Web;
using System.Web.Optimization;

namespace Panta
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/assets/js/jquery-1.10.2.js"));
            // < !--Google Maps Plugin    -->
            //@*< script type = "text/javascript" src = "https://maps.googleapis.com/maps/api/js" ></ script > *@

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Assets/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Assets/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/assets/js/bootstrap.min.js",
                       "~/assets/js/paper-dashboard.js",
                      "~/assets/js/bootstrap-notify.js",
                      "~/assets/js/bootstrap-checkbox-radio.js"));

            bundles.Add(new StyleBundle("~/assets/Content/css").Include(
                      "~/assets/css/bootstrap.min.css",
                      "~/assets/css/animate.min.css",
                      "~/assets/css/paper-dashboard.css"));


            bundles.Add(new ScriptBundle("~/bundles/chart").Include(
                      "~/assets/js/chartist.min.js"));
        }
    }
}
