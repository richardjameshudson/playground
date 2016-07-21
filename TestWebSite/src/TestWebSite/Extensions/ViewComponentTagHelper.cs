using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;

namespace TestWebSite
{ 


    [HtmlTargetElement("SoYouThinkYouAreAStar")]
    public class ViewComponentTagHelper : TagHelper
    {
        
        private readonly IViewComponentHelper _viewComponentHelper;

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public ViewComponentTagHelper(IViewComponentHelper viewComponentHelper)
        {
            _viewComponentHelper = viewComponentHelper;

        }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {


            output.TagName = null;
            ((IViewContextAware)_viewComponentHelper).Contextualize(ViewContext);
            var viewContent = await Task.Run(() => { return _viewComponentHelper.InvokeAsync("TestWebSite.Components.UI.Tile"); });
            output.Content.SetHtmlContent(viewContent);
        }
    }


}