using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIAbstraction.Data.Policy;
using UIAbstraction.UI.Components.Models;

namespace UIAbstraction.Data.UIInterfaces
{
    public class PanelWithTilesModelFactory : IPanelWithTilesModelFactory
    {
        public PanelWithTilesModel GetModel(string dataSource)
        {
            switch (dataSource.ToUpper())
            {
                case "DATA.POLICY.KEYFACTS":
                    return new KeyFacts().GetModel();
                case "DATA.POLICY.MAKEACHANGE":
                    return new MakeAChange().GetModel();
                default:
                    return null;
            }
        }
    }
}
