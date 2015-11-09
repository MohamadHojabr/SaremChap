using System.Web;
using System.Web.Optimization;

namespace SaremChap
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/Common/js").Include(
                "~/Content/assets/Common/bootstrap/js/bootstrap.min.js",
                "~/Content/assets/Common/dropzone/js/dropzone.min.js",
                "~/Content/assets/Common/dropzone/js/dropzone-amd-module.min",
                "~/Content/assets/Common/jquery.validetta/js/validetta.min.js",
                "~/Content/assets/Common/jquery.validetta/js/validettaLang-fa-IR.js",
                "~/Content/assets/Common/owl-carousel/owl.carousel.min.js",
                "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/bundles/Admin/js").Include(
                
                ));
            bundles.Add(new ScriptBundle("~/bundles/Front/js").Include(
                "~/Content/assets/Front/js/script.js",
                "~/Content/assets/Front/js/jquery.appear.js",
                "~/Content/assets/Front/js/jquery.fitvids.js",
                "~/Content/assets/Front/js/jquery.isotope.min.js",
                "~/Content/assets/Front/js/jquery.lettering.js",
                "~/Content/assets/Front/js/jquery.migrate.js",
                "~/Content/assets/Front/js/jquery.nicescroll.min.js",
                "~/Content/assets/Front/js/jquery.parallax.js",
                "~/Content/assets/Front/js/jquery.textillate.js",
                "~/Content/assets/Front/js/nivo-lightbox.min.js"
                ));

            bundles.Add(new StyleBundle("~/Content/Common/css")
                .Include("~/Content/assets/Common/bootstrap/css/bootstrap.min.css",
                new CssRewriteUrlTransform())
                .Include(
                "~/Content/assets/Common/animation/animate.css",
                "~/Content/assets/Common/bootstrap/css/responsive.css",
                "~/Content/assets/Common/dropzone/css/basic.min.css",
                "~/Content/assets/Common/jquery.validetta/css/validetta.min.css",
                "~/Content/assets/Common/Site-css/Site.css",
                "~/Content/assets/Common/owl-carousel/owl.theme.css",
                "~/Content/assets/Common/owl-carousel/owl.transitions.css")
                .Include("~/Content/assets/Common/dropzone/css/dropzone.min.css",
                new CssRewriteUrlTransform())
                .Include("~/Content/assets/Common/owl-carousel/owl.carousel.css",
                new CssRewriteUrlTransform())
                .Include("~/Content/assets/Common/font-awesome/css/font-awesome.min.css",
                new CssRewriteUrlTransform()
                ));

            bundles.Add(new StyleBundle("~/Content/Admin/css").Include(
                
                ));

            bundles.Add(new StyleBundle("~/Content/Front/css").Include(
                "~/Content/assets/Front/css/colors/purple.css",
                "~/Content/assets/Front/css/hover-min.css")
                .Include("~/Content/assets/Front/css/style.css",
                new CssRewriteUrlTransform()
                ));
        }
    }
}
