using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestWebSite.Components.UI
{
    public class Layout : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.Run(() => View());
        }
    }
}
