using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIAbstraction.UI.Components.Models;

namespace UIAbstraction.Data
{
    public interface IPanelWithTilesModelFactory
    {
        PanelWithTilesModel GetModel(string dataSource);
    }
}
