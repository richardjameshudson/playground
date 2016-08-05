using System.Threading.Tasks;
using NoCMSTestSite.Data.Person;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using NoCMSTestSite.Extensions;
using NoCMSTestSite.UIComponents.Models;

namespace NoCMSTestSite.UIComponents
{
    public class SoYourAStar : ViewComponent
    {
        private readonly IPerson _person;

        public SoYourAStar(IPerson person)
        {
            _person = person;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await Task.Run(() => new SoYourAStarModelBuilder(_person).GetModel());
            return this.ComponentView(model);
        }


    }
}
