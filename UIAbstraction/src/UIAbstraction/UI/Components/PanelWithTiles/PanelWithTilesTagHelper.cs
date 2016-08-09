using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.DependencyInjection;
using UIAbstraction.Data;

namespace UIAbstraction.UI.Components
{
    [HtmlTargetElement("UIComponents.PanelWithTiles")]
    public class PanelWithTilesTagHelper : Extensions.ViewComponentTagHelper
    {
        private IPanelWithTilesModelFactory _model;

        public PanelWithTilesTagHelper(IViewComponentHelper viewComponentHelper,
            IPanelWithTilesModelFactory modelFactory) : base(viewComponentHelper, nameof(PanelWithTiles))
        {
            _model = modelFactory;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            Model = _model.GetModel(ModelSource);
            await base.ProcessAsync(context, output);
        }
    }
}
