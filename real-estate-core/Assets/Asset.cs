using RealEstate.Core.Pricers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate.Core.Assets
{
    public class Asset : IAsset
    {
        public IPricer GetPricer()
        {
            return new AssetPricer();
        }
    }
}
