using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace NoCMSTestSite.UIComponents
{
    [HtmlTargetElement("Components.Business.Login")]
    public class LoginTagHelper : Extensions.ViewComponentTagHelper
    {
        public LoginTagHelper(IViewComponentHelper viewComponentHelper) : base(viewComponentHelper, nameof(Login)) { }

    }
}
