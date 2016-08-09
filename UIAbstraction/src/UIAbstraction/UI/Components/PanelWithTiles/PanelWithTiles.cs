using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace UIAbstraction.UI.Components
{
    
    public class PanelWithTiles : ViewComponent
    {
        public PanelWithTiles(){}

        public async Task<IViewComponentResult> InvokeAsync(UI.Components.Models.PanelWithTilesModel model)
        {
            return View("~/UI/Components/PanelWithTiles/Views/default.cshtml", model);
        }
    }
}
