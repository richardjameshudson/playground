using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UIAbstraction.Context
{
    public class JsonResourceProvider : IResource
    {
        public IEnumerable<Resource> GetResources(string componentName)
        {
            return JsonConvert.DeserializeObject<IEnumerable<Resource>>(GetJsonFileAsString()).ToList().Where(x=>x.Component==componentName);
        }

        private string GetJsonFileAsString()
        {
            return System.IO.File.ReadAllText("Resources/resource.json");


        }
    }
}
