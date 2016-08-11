using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor;

namespace UIAbstraction.Extensions
{
    public class BrandViewLocationExpander : IViewLocationExpander
    {


        public void PopulateValues(ViewLocationExpanderContext context)
        {


            var contextPath = string.Empty;
            switch (context.ActionContext.HttpContext.Request.Host.Port)
            {
                case 60001:
                    contextPath = "RAC/";
                    break;
                case 60002:
                    contextPath = "Postoffice/";
                    break;
                case 60003:
                    contextPath = "Zenith/";
                    break;
                default:
                    contextPath = string.Empty;
                    break;

            }


            context.Values["contextPath"] = contextPath;
        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {


            var customLocations = viewLocations.Select(locations => locations.Replace(@"/Views/", @"/Views/" + context.Values["contextPath"])).ToList();
            if (!string.IsNullOrEmpty(context.Values["contextPath"]))
            {
                customLocations.AddRange(viewLocations.Select(locations => locations).ToList());
            }

            return customLocations;






        }




    }
}
