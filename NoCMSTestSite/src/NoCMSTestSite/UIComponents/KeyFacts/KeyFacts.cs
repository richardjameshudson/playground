using System.Threading.Tasks;
using NoCMSTestSite.Data.Person;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using NoCMSTestSite.Data.Policy;
using NoCMSTestSite.Extensions;
using NoCMSTestSite.UIComponents.Models;

namespace NoCMSTestSite.UIComponents
{
    public class KeyFacts : ViewComponent
    {
        private readonly IKeyFacts _keyFacts;

        public KeyFacts(IKeyFacts keyFacts)
        {
            _keyFacts = keyFacts;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await Task.Run(() => new KeyFactsModelBuilder(_keyFacts).GetModel());
            return this.ComponentView(model);
        }


    }
}
