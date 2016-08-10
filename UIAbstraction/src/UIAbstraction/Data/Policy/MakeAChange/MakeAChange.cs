using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIAbstraction.Data;
using UIAbstraction.UI.Components.Models;

namespace UIAbstraction.Data.Policy
{
    public class MakeAChange
    {

        private UI.Components.Models.PanelWithTilesModel _model;

        public MakeAChange()
        {
            _model = new PanelWithTilesModel()
            {
                PanelTitle = "Make a change",
                PanelClass = "panel-danger",
                TileData = new List<TileData>()
                {
                    new TileData() {TileTitle="Change Address", TileImageCaption="", TileImageSource = "http://placekitten.com/100/100"},
                    new TileData() {TileTitle="Change Vehicle", TileImageCaption="", TileImageSource = "http://placebear.com/100/100"},
                    new TileData() {TileTitle="Add driver", TileImageCaption="", TileImageSource = "http://baconmockup.com/100/100"},
                    new TileData() {TileTitle="Remove driver", TileImageCaption="", TileImageSource = "http://placekitten.com/100/100"},
                }
            };
        }

        public PanelWithTilesModel GetModel()
        {
            return _model;
        }

    }
}
