using System;
using System.Collections.Generic;

namespace NoCMSTestSite.Data.Policy
{
    public class KeyFacts : IKeyFacts
    {

        public KeyFacts() { }

        public IEnumerable<KeyFactsEntity> GetKeyFacts()
        {
            return new List<KeyFactsEntity>()
            {
                new KeyFactsEntity() {KeyFactName = "Breakdown" },
                new KeyFactsEntity() {KeyFactName = "NCD Years" },
                new KeyFactsEntity() {KeyFactName = "Additional Drivers" }

            };
        }

      
    }
}