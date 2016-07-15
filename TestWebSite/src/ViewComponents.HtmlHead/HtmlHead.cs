using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestWebSite.ViewComponents
{
    public class HtmlHead : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewData["Title"] = "ARGHHHHHHHH";
            return View();
        }


    }
}
