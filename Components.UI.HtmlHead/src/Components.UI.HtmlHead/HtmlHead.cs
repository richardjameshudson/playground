using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestWebSite.Components.UI
{
    public class HtmlHead : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(string title, string stylefile)
        {
            await Task.Run(()=>ViewData["Title"] = title);
            await Task.Run(() => ViewData["StyleFile"] = stylefile);
            return View();
        }


    }
}
 