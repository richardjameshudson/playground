using System;

namespace NoCMSTestSite.Data.Person
{
    public class PersonEntity
    {
        public string PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string ProfileImage { get; set; }
    }
}