using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;

namespace TestWebSite.Components.UI
{
    public class TileModelBuilder
    {

        private TileModel _tileModel;

        public TileModelBuilder()
        {
            _tileModel = new TileModel();
        }

        public TileModelBuilder(IPerson person)
        {
            _tileModel = new UI.TileModel();
            var tiles = new List<TileItem>();
            foreach(var item in person.GetPersons())
            {
                tiles.Add(new TileItem()
                {
                    TileImage = item.ProfileImage,
                    TileText = item.FirstName + " " + item.LastName
                });
            }
            _tileModel.Tiles = tiles;

        }
        
        public TileModel GetInstance()
        {
            return _tileModel;
        }
    }
}
