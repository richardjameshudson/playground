using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebSite.Components.UI
{
    public class NavigationItem
    {
        public NavigationItem() { }
        public NavigationItem(string controller, string action, string name)
        {
            Controller = controller;
            Action = action;
            Name = name;
        }


        public string Controller { get; set; }
        public string Action { get; set; }
        public string Name { get; set; }
    }
}
