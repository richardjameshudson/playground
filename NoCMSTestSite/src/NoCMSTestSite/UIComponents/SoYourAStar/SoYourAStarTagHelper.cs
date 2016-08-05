using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace NoCMSTestSite.UIComponents
{
    [HtmlTargetElement("Components.Business.SoYourAStar")]
    public class SoYourAStarTagHelper : Extensions.ViewComponentTagHelper
    {
        public SoYourAStarTagHelper(IViewComponentHelper viewComponentHelper) : base(viewComponentHelper, nameof(SoYourAStar)) {}

    }
}
