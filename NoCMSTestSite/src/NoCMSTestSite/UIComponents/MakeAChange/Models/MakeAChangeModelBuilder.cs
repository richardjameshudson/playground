using System.Collections.Generic;
using System.Linq;
using NoCMSTestSite.Data.Person;
using NoCMSTestSite.Data.Policy;

namespace NoCMSTestSite.UIComponents.Models
{

    

    public class MakeAChangeModelBuilder
    {
        private readonly MakeAChangeModel _model;

        public MakeAChangeModelBuilder(IMTACapability mtaCapability)
        {
            _model = new MakeAChangeModel();
            _model.Items = mtaCapability.GetCapabilities().Select(item => new MakeAChangeItem()
            {
                Icon = GetIconForMTACode(item.MTACode),
                Title = GetTitleForMTACode(item.MTACode)
            }).ToList();
        }

        public MakeAChangeModel GetModel()
        {
            return _model;
        }


        private string GetIconForMTACode(string MTACode)
        {
            return string.Empty;
        }

        private string GetTitleForMTACode(string MTACode)
        {
            return "Test Title";
        }

    }
}
