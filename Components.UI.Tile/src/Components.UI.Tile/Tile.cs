using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TestWebSite.Components.UI
{
    public class Tile : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string config)
        {
            var model = await Task.Run(() => {
                return new TileModelBuilder(config).GetInstance();
            });
            return View(model);
        }
    }
}
