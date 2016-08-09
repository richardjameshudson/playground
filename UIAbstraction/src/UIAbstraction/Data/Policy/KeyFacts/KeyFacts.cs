using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIAbstraction.UI.Components.Models;

namespace UIAbstraction.Data.Policy
{
    public class KeyFactsPanelWithTiles
    {

        private UI.Components.Models.PanelWithTilesModel _model;

        public KeyFactsPanelWithTiles()
        {
            _model = new PanelWithTilesModel()
            {
                PanelTitle = "This is a test",
                PanelClass = "panel-danger",
                TileData = new List<TileData>()
                {
                    new TileData() {TileTitle="Murray", TileImageCaption="Bill Murray", TileImageSource = "http://fillmurray.com/100/100"},
                    new TileData() {TileTitle="Cage", TileImageCaption="Nicholas Cage", TileImageSource = "http://www.placecage.com/100/100"},
                    new TileData() {TileTitle="Seagal", TileImageCaption="Steven Seagal", TileImageSource = "http://www.stevensegallery.com/100/100"},
                }
            };
        }

        public UI.Components.Models.PanelWithTilesModel GetData()
        {
            return _model;
        }
        
    }
}
