using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace UIAbstraction.UI.Components
{
    [HtmlTargetElement("UICollection.Tile")]
    public class TileTagHelper : Extensions.UICollectionTagHelper
    {

        [HtmlAttributeName("title")]
        public string Title { get; set; }

        [HtmlAttributeName("image-source")]
        public string ImageSource { get; set; }

        [HtmlAttributeName("image-caption")]
        public string ImageCaption { get; set; }

        public TileTagHelper(IViewComponentHelper viewComponentHelper) : base(viewComponentHelper, "tile"){}

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            ReplacementValues = new Dictionary<string, string>()
            {
                {"tile_title", Title },
                {"tile_image_source", ImageSource },
                {"tile_image_caption", ImageCaption }
            };
            return base.ProcessAsync(context, output);
        }
    }
}
