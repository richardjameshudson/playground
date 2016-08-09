using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using UIAbstraction.Data;
using UIAbstraction.UI.Components.Models;

namespace UIAbstraction.UI.Components
{
    
    public class PanelWithTiles : ViewComponent
    {
        
        public PanelWithTiles(){}

        public async Task<IViewComponentResult> InvokeAsync(PanelWithTilesModel model)
        {
            //var model = await Task.Run(()=>modelFactory.GetModel());
            
            return View("~/UI/Components/PanelWithTiles/Views/default.cshtml", model);
        }
    }
}
