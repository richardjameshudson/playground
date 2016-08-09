using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIAbstraction.Data.Policy;
using UIAbstraction.UI.Components.Models;

namespace UIAbstraction.Data
{
    public class PanelWithTilesModelFactory : IPanelWithTilesModelFactory
    {
        public PanelWithTilesModel GetModel(string dataSource)
        {
            if (dataSource.Contains("KeyFacts"))
            {
                return new KeyFactsPanelWithTiles().GetModel();
            }
            else
            {
                return null;
            }
        }
    }
}
