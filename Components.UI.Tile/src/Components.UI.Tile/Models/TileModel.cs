using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebSite.Components.UI
{
    public class TileModel
    {
        public string ContainerTitle { get; set; }
        public IEnumerable<TileItem> Tiles { get; set; }

        public bool IsSingleTileView { get { return Tiles.Count() == 1 && string.IsNullOrEmpty(ContainerTitle); } }
    }
}
