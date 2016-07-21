using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data;
using System.Linq;

namespace TestWebSite.Components.UI
{
    public class Tile : ViewComponent
    {
        private readonly IPerson _person;

        public Tile(IPerson person)
        {
            _person = person;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await Task.Run(() => {
                return new TileModelBuilder(_person).GetInstance();
            });
            return View(model);
        }
    }
}
