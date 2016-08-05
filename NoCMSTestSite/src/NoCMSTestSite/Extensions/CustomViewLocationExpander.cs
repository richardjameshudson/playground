using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor;

namespace NoCMSTestSite
{
    public class CustomViewLocationExpander : IViewLocationExpander
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
                    contextPath = "Base/";
                    break;

            }
            
            //var contextPathAdditional = string.Join("/", context.ActionContext.RouteData.Values["process"],context.ActionContext.RouteData.Values["product"]);
            //if (contextPathAdditional.Length>0 && contextPathAdditional.Substring(contextPathAdditional.Length)!=@"/"){contextPathAdditional += @"/";}
            context.Values["contextPath"] = contextPath;
        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {

            //ViewLocations:
            //Pages
            //1. Views/{brand}/{process}/{product}/..
            //2. Views/{brand}/{process}/..
            //3. Views/{brand}/{product}/..
            //4. Views/{brand}/..
            //5. Views/..
            //Components
            //1. UIComponents/{name}/Views/{brand}/{process}/{product}/Default
            //1. UIComponents/{name}/Views/{brand}/{process}/Default
            //1. UIComponents/{name}/Views/{brand}/{product}/Default
            //1. UIComponents/{name}/Views/{brand}/Default
            //1. UIComponents/{name}/Views/Default


            var customLocations = viewLocations.Select(locations => locations.Replace(@"/Views/", @"/Views/" + context.Values["contextPath"])).ToList();
            if (context.Values["contextPath"]!="Base/")
            {
                customLocations.AddRange(viewLocations.Select(locations => locations.Replace(@"/Views/", @"/Views/Base/")).ToList());
            }

            return customLocations;




            //return viewLocations.Select(locations => locations.Replace(@"/Views/", @"/Views/" + context.Values["contextPath"]));


            //List <string> newLocations =
            //    new List<string>(viewLocations.Select(locations => locations.Replace(@"/Views/", @"/Views/"
            //                      + context.Values["theme"] + @"/"
            //                      + context.ActionContext.RouteData.Values["process"] + @"/"
            //                      + context.ActionContext.RouteData.Values["product"] + @"/"
            //        )));
            
            //return newLocations;

        }




    }

    
}
