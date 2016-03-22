using System.Web;
using System.Web.Optimization;

namespace RAD302_S00144297
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            //JQuery UI
            bundles.Add(new ScriptBundle("~/bundles/JQueryUI").Include(
                        "~/Scripts/jquery-ui-1.11.4.min.js"));

            //First Visit Popup
            bundles.Add(new ScriptBundle("~/bundles/jqueryFirstVisitPopup").Include(
            "~/Scripts/jquery.firstVisitPopup.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Dialog").Include(
                     "~/Content/themes/base/dialog.css"));
        }
    }
}
