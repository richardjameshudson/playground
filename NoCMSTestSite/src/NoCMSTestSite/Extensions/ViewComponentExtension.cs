using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace NoCMSTestSite.Extensions
{
    public static class ViewComponentExtension
    {
        public static ViewViewComponentResult ComponentView<T>(this ViewComponent viewComponent, T model)
        {
            return viewComponent.View(viewComponent.GetViewName(), model);
        }
        public static ViewViewComponentResult ComponentView(this ViewComponent viewComponent)
        {
            return viewComponent.View(viewComponent.GetViewName());
        }

        private static string GetViewName(this ViewComponent viewComponent)
        {
            return $"~/UIComponents/{viewComponent.ViewComponentContext.ViewComponentDescriptor.ShortName}/Views/default.cshtml";
        }
    }
}
