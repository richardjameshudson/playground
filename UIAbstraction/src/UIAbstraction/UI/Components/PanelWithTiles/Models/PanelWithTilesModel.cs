using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIAbstraction.UI.Components.Models
{
    public class PanelWithTilesModel
    {
        public string PanelTitle;
        public string PanelClass;
        public IEnumerable<TileData> TileData;

    }

    public class TileData
    {
        public string TileTitle;
        public string TileImageSource;
        public string TileImageCaption;

    }
}
