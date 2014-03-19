using dotless.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace VIdme.App_Start
{
    public class LessTransform :IBundleTransform
    {
        public void Process(BundleContext context, BundleResponse response)
        {
            response.Content = Less.Parse(response.Content);
            response.ContentType = "text/css";
        }
    }
}