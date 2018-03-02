using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Panta.App_Start
{
    public class CustomRazorViewEngine : RazorViewEngine
    {
        public CustomRazorViewEngine()
        {
            ViewLocationFormats = new string[] { "~/Admin/{1}/Views/{0}.cshtml", "~/{1}/Views/{0}.cshtml", "~/Shared/Views/{0}.cshtml","~/Admin/Company/Views/{0}.cshtml" };
            PartialViewLocationFormats = new string[] { "~/{1}/Views/{0}.cshtml", "~/Shared/Views/{0}.cshtml" };
        }
    }
}