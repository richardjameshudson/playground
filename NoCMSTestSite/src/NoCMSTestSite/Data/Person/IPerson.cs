using System.Collections.Generic;

namespace NoCMSTestSite.Data.Person
{
    public interface IPerson
    {

        PersonEntity GetPerson();

        IEnumerable<PersonEntity> GetPersons();
    }
}