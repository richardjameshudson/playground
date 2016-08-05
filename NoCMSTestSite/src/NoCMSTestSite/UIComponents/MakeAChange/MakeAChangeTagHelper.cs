using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace NoCMSTestSite.UIComponents
{
    [HtmlTargetElement("Components.Business.MakeAChange")]
    public class MakeAChangeTagHelper : Extensions.ViewComponentTagHelper
    {
        public MakeAChangeTagHelper(IViewComponentHelper viewComponentHelper) : base(viewComponentHelper, nameof(MakeAChange)) { }

    }
}
