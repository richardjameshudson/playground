using System.Collections.Generic;

namespace NoCMSTestSite.Data.Policy
{
    public interface IKeyFacts
    {

        IEnumerable<KeyFactsEntity> GetKeyFacts();
    }
}