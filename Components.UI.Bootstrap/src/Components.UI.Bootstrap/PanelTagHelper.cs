using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Text;
using System.Threading.Tasks;

namespace TestWebSite.Components.UI.Bootstrap
{


    [HtmlTargetElement("bootstrap-panel", Attributes ="type, title")]
    public class PanelTagHelper : TagHelper
    {
        [HtmlAttributeName("title")]
        public string Title { get; set; }

        [HtmlAttributeName("type")]
        public PanelType Type { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            //<div class="panel {type}">
            //    <div class="panel-heading">
            //        <h3 class="panel-title">{Title}</h3>
            //    </div>
            //    <div class="panel-body">
            //      {Content}
            //    </div>
            //</div

            output.TagName = "div";
            output.Attributes.Add("class", "panel " + AddPanelTypeStyle(Type));
            var sb = new StringBuilder();
            sb.AppendLine(@"<div class=""panel-heading"">");
            sb.AppendLine(string.Format(@"<h3 class=""panel-title"">{0}</h3>", Title));
            sb.AppendLine(@"</div>");
            sb.AppendLine(@"<div class=""panel-body"">");
            output.PreContent.SetHtmlContent(sb.ToString());
            output.PostContent.SetHtmlContent(@"</div>");
        }

        private string AddPanelTypeStyle(PanelType type)
        {
            switch (type)
            {
                case PanelType.Default:
                    return "panel-default";
                case PanelType.Primary:
                    return "panel-primary";
                case PanelType.Info:
                    return "panel-info";
                case PanelType.Success:
                    return "panel-success";
                case PanelType.Warning:
                    return "panel-warning";
                case PanelType.Danger:
                    return "panel-danger";
                default:
                    throw new InvalidOperationException("The panel type specified is not specified or invalid");
            }
        }

        public enum PanelType
        {
            Default, Primary, Info, Success, Warning, Danger
        }

    }

    
}