using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace NoCMSTestSite.UIComponents
{
    [HtmlTargetElement("Components.Business.KeyFacts")]
    public class KeyFactsTagHelper : Extensions.ViewComponentTagHelper
    {
        public KeyFactsTagHelper(IViewComponentHelper viewComponentHelper) : base(viewComponentHelper, nameof(KeyFacts)) { }

    }
}
