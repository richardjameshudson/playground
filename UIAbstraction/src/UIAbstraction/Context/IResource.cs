using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIAbstraction.Context
{
    public interface IResource
    {
        Dictionary<string, string> GetResources(string Page, string componentName);
        string GetResource(string page, string componentName, string key);

    }
}
