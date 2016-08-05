using System.Collections.Generic;
using NoCMSTestSite.Data.Person;

namespace NoCMSTestSite.UIComponents.Models
{

    

    public class SoYourAStarModelBuilder
    {
        private readonly SoYourAStarModel _model;

        public SoYourAStarModelBuilder(IPerson person)
        {
            _model = new SoYourAStarModel();
            var items = new List<SoYourAStarItem>();
            foreach (var item in person.GetPersons())
            {
                items.Add(new SoYourAStarItem()
                {
                    Image = item.ProfileImage,
                    Name = item.FirstName + " " + item.LastName
                });
            }
            _model.Items = items;
        }

        public SoYourAStarModel GetModel()
        {
            return _model;
        }
        

    }
}
