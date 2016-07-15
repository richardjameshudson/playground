using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TestWebSite.Components.UI
{
    public class Navigation : ViewComponent
    {

        
        public async Task<IViewComponentResult> InvokeAsync(string navItems)
        {
            return await Task.Run(() => View(new NavigationModelBuilder(navItems).GetInstance()));
        }

        

    }
}
