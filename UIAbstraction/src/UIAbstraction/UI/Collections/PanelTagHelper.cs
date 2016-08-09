using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace UIAbstraction.UI.Components
{
    [HtmlTargetElement("UICollection.Panel")]
    public class PanelTagHelper : Extensions.UICollectionTagHelper
    {
        [HtmlAttributeName("class")]
        public string Class { get; set; }

        [HtmlAttributeName("title")]
        public string Title { get; set; }


        public PanelTagHelper(IViewComponentHelper viewComponentHelper) : base(viewComponentHelper, "panel") { }

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            ReplacementValues = new Dictionary<string, string>()
            {
                {"panel_class", Class},
                {"panel_title", Title}
            };
            return base.ProcessAsync(context, output);
        }
    }
}
