﻿using System.Web;
using System.Web.Optimization;

namespace BlogFall
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //JQUERY CDN Kullanımı
            //Publish edildiğinde adresi verilen dosyayı kullanır
            bundles.UseCdn = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery",
                "https://code.jquery.com/jquery-3.4.1.min.js").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/fontawesome-all.css",
                      "~/Content/toastr.css",
                      "~/Content/Site.css"));


            //CDN
            //DEBUG Modunde if aktif olur.
            #if DEBUG
            BundleTable.EnableOptimizations = false;
            #else
            BundleTable.EnableOptimizations = true;
            #endif
        }
    }
}
