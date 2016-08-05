using System.Threading.Tasks;
using NoCMSTestSite.Data.Person;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using NoCMSTestSite.Data.Policy;
using NoCMSTestSite.Extensions;
using NoCMSTestSite.UIComponents.Models;

namespace NoCMSTestSite.UIComponents
{
    public class MakeAChange : ViewComponent
    {
        private readonly IMTACapability _mtaCapability;

        public MakeAChange(IMTACapability mtaCapability)
        {
            _mtaCapability = mtaCapability;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await Task.Run(() => new MakeAChangeModelBuilder(_mtaCapability).GetModel());
            return this.ComponentView(model);
        }


    }
}
