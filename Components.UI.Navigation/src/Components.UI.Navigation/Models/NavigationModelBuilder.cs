using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebSite.Components.UI
{
    public class NavigationModelBuilder
    {

        private NavigationModel _navigationModel;

        public NavigationModelBuilder(NavigationModel model)
        {
            _navigationModel = model;

        }

        public NavigationModelBuilder(string navigationItems)
        {
            _navigationModel = new NavigationModel();
            if (!string.IsNullOrEmpty(navigationItems))
            {
                _navigationModel = Newtonsoft.Json.JsonConvert.DeserializeObject<NavigationModel>(navigationItems);
            }
            else
            {
                _navigationModel.NavigationItems = new List<NavigationItem>()
                {
                    new NavigationItem("Home", "Index", "Home"),
                    new NavigationItem("Home", "About", "About"),
                    new NavigationItem("Home", "Contact", "Contact")
                };
            }
        }


        public NavigationModel GetInstance()
        {
            OutputModelToJson();
            return _navigationModel;
        }


        private void OutputModelToJson()
        {

        }
    }
}
