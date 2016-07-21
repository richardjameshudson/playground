using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data
{
    public interface IPerson
    {

        PersonEntity GetPerson();

        IEnumerable<PersonEntity> GetPersons();
        
        
    }
}
