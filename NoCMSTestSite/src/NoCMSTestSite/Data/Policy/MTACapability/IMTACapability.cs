using System.Collections.Generic;

namespace NoCMSTestSite.Data.Policy
{
    public interface IMTACapability
    {

        IEnumerable<MTACapabilityEntity> GetCapabilities();
    }
}