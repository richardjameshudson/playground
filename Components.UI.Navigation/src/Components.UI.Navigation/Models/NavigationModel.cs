using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebSite.Components.UI
{
    [Serializable]
    public class NavigationModel
    {
        public NavigationModel()
        {
            NavigationItems = new List<NavigationItem>();
        }
        public IEnumerable<NavigationItem> NavigationItems { get; set; }
    }
}
