using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using UIAbstraction.Data;

namespace UIAbstraction.Extensions
{ 
    public class ViewComponentTagHelper : TagHelper
    {
        private IViewComponentHelper _viewComponentHelper;
        private string _componentName;
        

        public object Model { get; set; }

        [HtmlAttributeName("model-source")]
        public string ModelSource { get; set; }



        [ViewContext]
        public ViewContext ViewContext { get; set; }

        
        public ViewComponentTagHelper(IViewComponentHelper viewComponentHelper, string componentName)
        {
            _viewComponentHelper = viewComponentHelper;
            _componentName = componentName;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            
            output.TagName = null;
            ((IViewContextAware)_viewComponentHelper).Contextualize(ViewContext);
            var viewContent = await _viewComponentHelper.InvokeAsync(_componentName, new {model = Model});
            output.Content.SetHtmlContent(viewContent);
        }

       
    }
}
