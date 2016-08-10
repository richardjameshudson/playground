using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIAbstraction.Context
{
    
    public class Resource
    {
        public string Component { get; set; }
        public Dictionary<string, string> ComponentResources { get; set; }
    }

}
