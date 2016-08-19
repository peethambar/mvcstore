using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace OnlineShoppingSite.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/css").Include("~/Content/Site.css", "~/Content/bootstrap.min.css"));

            bundles.Add(new ScriptBundle("~/scripts/js").Include("~/Scripts/jquery-1.10.2.min.js", "~/Scripts/jquery.validate.min.js", "~/Scripts/jquery.validate.unobtrusive.min.js"));
        }
    }
}