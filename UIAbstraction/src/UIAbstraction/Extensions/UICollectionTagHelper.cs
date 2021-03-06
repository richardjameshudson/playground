﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Server.Kestrel;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.DotNet.InternalAbstractions;

namespace UIAbstraction.Extensions
{
    
    public class UICollectionTagHelper : TagHelper
    {
        private IViewComponentHelper _viewComponentHelper;
        private string _collectionName;
        private string[] _htmlContent;

        public Dictionary<string, string> ReplacementValues { get; set; }
        

        public UICollectionTagHelper(IViewComponentHelper viewComponentHelper, string collectionName)
        {
            _viewComponentHelper = viewComponentHelper;
            _collectionName = collectionName;
            
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            _htmlContent = await Task.Run(()=>GetUICollectionHtml(output.Attributes));
            if (IsContentEmpty())
            {
                output.Content.SetHtmlContent(_htmlContent[0]);
            }
            else
            {
                output.PreContent.SetHtmlContent(_htmlContent[0]);
                output.PostContent.SetHtmlContent(_htmlContent[1]);
            }
            output.TagName = null;
        }


        private string[] GetUICollectionHtml(TagHelperAttributeList attributes)
        {
            var htmlContent = System.IO.File.ReadAllText("ui/collections/" + _collectionName + "/" + _collectionName + ".html");
            if (attributes.Any() && !string.IsNullOrEmpty(htmlContent)) 
            {
                var attr = string.Empty;
                foreach (var item in attributes)
                {
                    attr += item.Name + "=\"" + item.Value + "\" ";
                }

                var ind = htmlContent.IndexOf('>');
                htmlContent = htmlContent.Substring(0, ind) + " " + attr + htmlContent.Substring(ind);
            }
            
            if (ReplacementValues != null)
            {
                foreach (var item in ReplacementValues)
                {
                    htmlContent = htmlContent.Replace("{" + item.Key + "}", item.Value);
                }
            }

            return htmlContent.Split(new string[] {"{content}"}, StringSplitOptions.RemoveEmptyEntries);

        }

        
        private bool IsContentEmpty()
        {
            return _htmlContent != null && _htmlContent.Length == 1;
        }
    }
}
