using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace UIAbstraction.UI.Components
{
    [HtmlTargetElement("UICollection.Modal")]
    public class ModalTagHelper : Extensions.UICollectionTagHelper
    {
        [HtmlAttributeName("id")]
        public string Id { get; set; }

        [HtmlAttributeName("title")]
        public string Title { get; set; }

        [HtmlAttributeName("closebutton")]
        public string CloseButton { get; set; }

        [HtmlAttributeName("savebutton")]
        public string SaveButton { get; set; }



        public ModalTagHelper(IViewComponentHelper viewComponentHelper) : base(viewComponentHelper, "modal") { }

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            ReplacementValues = new Dictionary<string, string>()
            {
                {"id", Id},
                {"closebutton", CloseButton},
                {"savebutton", SaveButton},
                {"title", Title }
            };
            return base.ProcessAsync(context, output);
        }
    }
}
