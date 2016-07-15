using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebSite.Components.UI
{
    public class TileModelBuilder
    {

        private TileModel _tileModel;

        public TileModelBuilder()
        {
            _tileModel = new TileModel();
        }

        public TileModelBuilder(string jsonConfig) {
            if (!string.IsNullOrEmpty(jsonConfig))
            {
                _tileModel = Newtonsoft.Json.JsonConvert.DeserializeObject<TileModel>(jsonConfig);
            }
            else
            {
                _tileModel = new TileModel();
            }
        }
        
        public TileModel GetInstance()
        {
            return _tileModel;
        }
    }
}
