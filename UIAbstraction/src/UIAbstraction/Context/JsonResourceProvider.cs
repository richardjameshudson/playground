using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UIAbstraction.Context
{
    public class JsonResourceProvider : IResource
    {
        private List<Resource> _resources;

        public JsonResourceProvider()
        {
            _resources = GetResourceObject();
        }

        public string GetResource(string page, string componentName, string key)
        {
            return GetDictionary(page, componentName).ComponentResources[key];
        }

        public Dictionary<string, string> GetResources(string page, string componentName)
        {
            return GetDictionary(page, componentName).ComponentResources;
        }





        private Resource GetDictionary(string page, string component)
        {
            return _resources.FirstOrDefault(x => x.Component == component && x.Page == page);
        }

        private List<Resource> GetResourceObject()
        {
            return JsonConvert.DeserializeObject<List<Resource>>(System.IO.File.ReadAllText("context/resource.json"));


        }
    }
}
