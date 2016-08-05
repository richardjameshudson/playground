using System.Threading.Tasks;
using NoCMSTestSite.Data.Person;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using NoCMSTestSite.Data.Policy;
using NoCMSTestSite.Extensions;
using NoCMSTestSite.UIComponents.Models;

namespace NoCMSTestSite.UIComponents
{
    public class Login : ViewComponent
    {
        //private readonly IKeyFacts _keyFacts;

        public Login(){}

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return this.ComponentView();
        }


    }
}
