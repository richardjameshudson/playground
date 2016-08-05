using System;
using System.Collections.Generic;

namespace NoCMSTestSite.Data.Person
{
    public class Person : IPerson
    {
        public Person() { }

        PersonEntity IPerson.GetPerson()
        {
            return new PersonEntity()
            {
                DateOfBirth = new DateTime(1980, 5, 20),
                FirstName = "Bill",
                LastName = "Murray",
                PersonId = "1234",
                ProfileImage = @"http://fillmurray.com/100/100\"
            };
        }

        IEnumerable<PersonEntity> IPerson.GetPersons()
        {
            return new List<PersonEntity>()
            {
                new PersonEntity() {
                    DateOfBirth = new DateTime(1960, 8, 25),
                    FirstName = "Bill",
                    LastName = "Murray",
                    PersonId = "1234",
                    ProfileImage = @"http://fillmurray.com/100/100"
                },
                new PersonEntity() {
                    DateOfBirth = new DateTime(1950, 3, 10),
                    FirstName = "Steven",
                    LastName = "Segal",
                    PersonId = "1235",
                    ProfileImage = @"http://www.stevensegallery.com/100/100"
                },
                new PersonEntity() {
                    DateOfBirth = new DateTime(1980, 5, 20),
                    FirstName = "Nicholas",
                    LastName = "Cage",
                    PersonId = "1236",
                    ProfileImage = @"http://www.placecage.com/100/100"
                }
            };
        }
    }
}