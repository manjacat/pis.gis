using System.Web;
using System.Web.Optimization;

namespace PIS.GIS
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //ScriptBundle
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/plugins/jquery-ui/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                 "~/plugins/bootstrap/js/bootstrap.bundle.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/plugins/chart.js/Chart.min.js", //Chart js
                "~/plugins/sparklines/sparkline.js", //Sparkline
                "~/plugins/jqvmap/jquery.vmap.min.js", //JVQMap
                "~/plugins/jqvmap/maps/jquery.vmap.usa.js",
                "~/plugins/jquery-knob/jquery.knob.min.js", //Jqyery Knob Chart
                "~/plugins/moment/moment.min.js", //daterangepicker
                "~/plugins/daterangepicker/daterangepicker.js",
                "~/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js", //Tempusdominus Bootstrap 4
                "~/plugins/summernote/summernote-bs4.min.js", //Summernote
                "~/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js", //overlayScrollBars
                "~/dist/js/adminlte.js", //AdminLTE app
                "~/dist/js/pages/dashboard.js", //AdminLTE dashboard demo (demo purposes!)
                "~/dist/js/demo.js" //AdminLTE for demo purposes
                ));

            bundles.Add(new ScriptBundle("~/bundles/chartjs").Include(
                "~/plugins/chart.js/Chart.min.js" //Chart js                       
                ));

            bundles.Add(new ScriptBundle("~/bundles/sparkline").Include(
                "~/plugins/sparklines/sparkline.js" //Sparkline
                ));

            bundles.Add(new ScriptBundle("~/bundles/jvqmap").Include(
                "~/plugins/jqvmap/jquery.vmap.min.js",
                "~/plugins/jqvmap/maps/jquery.vmap.usa.js" //JVQMap                        
                ));

            bundles.Add(new ScriptBundle("~/bundles/knobchart").Include(
                "~/plugins/jquery-knob/jquery.knob.min.js" //Jqyery Knob Chart
                ));

            bundles.Add(new ScriptBundle("~/bundles/daterangepicker").Include(                
                "~/plugins/moment/moment.min.js", //daterangepicker
                "~/plugins/daterangepicker/daterangepicker.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/tempusdominus").Include(
                "~/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js" //Tempusdominus Bootstrap 4
                ));

            bundles.Add(new ScriptBundle("~/bundles/summernote").Include(
                "~/plugins/summernote/summernote-bs4.min.js" //Summernote                
                ));

            bundles.Add(new ScriptBundle("~/bundles/overlayscrollbar").Include(
                "~/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js" //overlayScrollBars               
                ));

            bundles.Add(new ScriptBundle("~/bundles/adminlte").Include(
                "~/dist/js/adminlte.js", //AdminLTE app
                "~/dist/js/pages/dashboard.js", //AdminLTE dashboard demo (demo purposes!)
                "~/dist/js/demo.js" //AdminLTE for demo purposes
                ));

            //StyleBundle
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/plugins/fontawesome-free/css/all.min.css",
                "~/plugins/ionicons/css/ionicons.min.css",
                "~/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                "~/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                "~/plugins/jqvmap/jqvmap.min.css",
                "~/dist/css/adminlte.min.css",
                "~/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                "~/plugins/daterangepicker/daterangepicker.css",
                "~/plugins/summernote/summernote-bs4.css"
                ));


        }
    }
}
