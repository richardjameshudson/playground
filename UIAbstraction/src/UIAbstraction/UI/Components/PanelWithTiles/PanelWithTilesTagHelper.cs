using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.DependencyInjection;
using UIAbstraction.Data;
using UIAbstraction.Data.UIInterfaces;

namespace UIAbstraction.UI.Components
{
    [HtmlTargetElement("UIComponents.PanelWithTiles")]
    public class PanelWithTilesTagHelper : Extensions.ViewComponentTagHelper
    {
        private IPanelWithTilesModelFactory _modelFactory;

        [HtmlAttributeName("title")]
        public string PanelWithTilesTitle { get; set; }

        [HtmlAttributeName("class")]
        public string PanelWithTilesClass { get; set; }


        public PanelWithTilesTagHelper(IViewComponentHelper viewComponentHelper,
            IPanelWithTilesModelFactory modelFactory) : base(viewComponentHelper, nameof(PanelWithTiles))
        {
            _modelFactory = modelFactory;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var thisModel = _modelFactory.GetModel(ModelSource);
            thisModel.PanelTitle = PanelWithTilesTitle;
            thisModel.PanelClass = PanelWithTilesClass;
            Model = thisModel;
            await base.ProcessAsync(context, output);
        }
    }
}
