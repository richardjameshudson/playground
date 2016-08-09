using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.DependencyInjection;

namespace UIAbstraction.UI.Components
{
    [HtmlTargetElement("UIComponents.PanelWithTiles")]
    public class PanelWithTilesTagHelper : Extensions.ViewComponentTagHelper
    {
        
        public PanelWithTilesTagHelper(IViewComponentHelper viewComponentHelper) : base(viewComponentHelper, nameof(PanelWithTiles)){}
        
    }
}
