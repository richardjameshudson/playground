using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIAbstraction.Context;
using UIAbstraction.Data;
using UIAbstraction.UI.Components.Models;

namespace UIAbstraction.Data.Policy
{
    public class KeyFacts
    {

        private UI.Components.Models.PanelWithTilesModel _model;
        private IEnumerable<Resource> _resources;

        public KeyFacts()
        {
            //_resources = resources.GetResources(this.GetType().FullName);
            _model = new PanelWithTilesModel()
            {
                PanelTitle = "Key facts",
                PanelClass = "panel-info",
                TileData = new List<TileData>()
                {
                    new TileData() {TileTitle="Excess", TileImageCaption="Bill Murray", TileImageSource = "http://fillmurray.com/100/100"},
                    new TileData() {TileTitle="NCD Years", TileImageCaption="Nicholas Cage", TileImageSource = "http://www.placecage.com/100/100"},
                    new TileData() {TileTitle="Cover Options", TileImageCaption="Steven Seagal", TileImageSource = "http://www.stevensegallery.com/100/100"},
                }
            };
        }

        public PanelWithTilesModel GetModel()
        {
            return _model;
        }

    }
}
