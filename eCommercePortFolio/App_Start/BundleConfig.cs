﻿using System.Web;
using System.Web.Optimization;

namespace eCommercePortFolio
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundle/additional-js").Include(
                    "~/vendor/jquery/jquery-3.2.1.min.js",
                    "~/vendor/animsition/js/animsition.min.js",
                    "~/vendor/bootstrap/js/popper.js",
                    "~/vendor/bootstrap/js/bootstrap.min.js",
                "~/vendor/select2/select2.min.js",
                    "~/vendor/slick/slick.min.js",
                    "~/js/slick-custom.js",
                    "~/vendor/countdowntime/countdowntime.js",
                    "~/vendor/lightbox2/js/lightbox.min.js",
                    "~/vendor/sweetalert/sweetalert.min.js",
                "~/vendor/parallax100/parallax100.js",
                "~/js/main.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/additional-css").Include(
                "~/vendor/bootstrap/css/bootstrap.min.css",
                "~/fonts/font-awesome-4.7.0/css/font-awesome.min.css",
                "~/fonts/themify/themify-icons.css",
                "~/fonts/Linearicons-Free-v1.0.0/icon-font.min.css",
                "~/fonts/elegant-font/html-css/style.css",
                "~/vendor/animate/animate.css",
                    "~/vendor/css-hamburgers/hamburgers.min.css",
                    "~/vendor/animsition/css/animsition.min.css",
                    "~/vendor/select2/select2.min.css",
                    "~/vendor/daterangepicker/daterangepicker.css",
                    "~/vendor/slick/slick.css",
                    "~/vendor/lightbox2/css/lightbox.min.css",
                "~/vendor/noui/nouislider.min.css",
                    "~/css/util.css",
                    "~/css/main.css"));
        }
    }
}
