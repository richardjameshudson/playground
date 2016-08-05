using System.Collections.Generic;
using System.Linq;
using NoCMSTestSite.Data.Person;
using NoCMSTestSite.Data.Policy;

namespace NoCMSTestSite.UIComponents.Models
{

    

    public class KeyFactsModelBuilder
    {
        private readonly KeyFactsModel _model;

        public KeyFactsModelBuilder(IKeyFacts keyFacts)
        {
            _model = new KeyFactsModel
            {
                Items = keyFacts.GetKeyFacts().Select(item => new KeyFactsItem()
                {
                    Icon = item.KeyFactName
                }).ToList()
            };
        }

        public KeyFactsModel GetModel()
        {
            return _model;
        }



    }
}
