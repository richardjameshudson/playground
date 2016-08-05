using System;
using System.Collections.Generic;

namespace NoCMSTestSite.Data.Policy
{
    public class MTACapability : IMTACapability
    {

        public MTACapability() { }

        public IEnumerable<MTACapabilityEntity> GetCapabilities()
        {
            return new List<MTACapabilityEntity>()
            {
                new MTACapabilityEntity() {MTACode = "CHGADD"},
                new MTACapabilityEntity() {MTACode = "CHGVEH"},
                new MTACapabilityEntity() {MTACode = "ADDDRV"},
                new MTACapabilityEntity() {MTACode = "RMVDRV"},
                new MTACapabilityEntity() {MTACode = "CHGCVR"}
            };
        }

      
    }
}