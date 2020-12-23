using RealEstate.Core.Pricers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate.Core.Assets
{
    public interface IAsset
    {
        public IPricer GetPricer();
    }
}
