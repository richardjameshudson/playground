﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIAbstraction.Context
{
    public interface IResource
    {
        IEnumerable<Resource> GetResources(string componentName);
    }
}
