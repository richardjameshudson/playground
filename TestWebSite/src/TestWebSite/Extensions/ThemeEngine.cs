using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace TestWebSite
{


    public class ThemeEngine : IViewLocationExpander
    {


        public void PopulateValues(ViewLocationExpanderContext context)
        {
            var x = 1;
            switch (context.ActionContext.HttpContext.Request.Host.Port)
            {
                case 60001:
                    context.Values["theme"] = "Theme2/";
                    break;
                default:
                    context.Values["theme"] = "Theme1/";
                    break;


            }
        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            var existingViewLocations = viewLocations.ToList();
            existingViewLocations.AddRange(viewLocations.Select(f => f.Replace("/Views/", "/Views/" + context.Values["theme"])));
            return existingViewLocations;
        }

    }
}
