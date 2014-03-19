using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Transformers;
using System.Web;
using System.Web.Optimization;
using VIdme.App_Start;

namespace VIdme
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            var cssTransformer = new CssTransformer();
            var jsTransformer = new JsTransformer();
            var nullOrderer = new NullOrderer();

            var css = new Bundle("~/bundles/css")
                .Include("~/Content/site.less")
                .Include("~/Content/VideoPlayer/video-default.css");
            css.Transforms.Add(cssTransformer);
            css.Orderer = nullOrderer;

            bundles.Add(css);

            var jquery = new Bundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-1.*")
                .Include("~/Content/VideoPlayer/*.js");
            jquery.Transforms.Add(jsTransformer);
            jquery.Orderer = nullOrderer;

            bundles.Add(jquery);

            // If you'd like to test the optimization locally,
            // you can use this line to force it.
            // BundleTable.EnableOptimizations = true;    





         //   bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
         //               "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-ui").Include(
                "~/Scripts/ui-bootstrap-tpls-*"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));


            //var lessBundle = new Bundle("~/Content/Styles");

            //lessBundle.Include("~/Content/Site.less");

            //lessBundle.Transforms.Add(new LessTransform());
            //lessBundle.Transforms.Add(new CssMinify());

            //bundles.Add(lessBundle);

        }
    }
}
