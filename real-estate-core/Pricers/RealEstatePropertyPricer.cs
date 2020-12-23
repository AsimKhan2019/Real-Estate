using RealEstate.Core.Assets;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate.Core.Pricers
{
    public class RealEstatePropertyPricer : AssetPricer
    {
        public RealEstatePropertyPricer(IAsset asset) : base(asset) { }

        public RealEstateProperty Property => Asset as RealEstateProperty;

        public double ComputeMarketPricePerSurface()
        {
            if (Math.Abs(Property.Surface) < double.Epsilon)
            {
                return 0.0;
            }
            return Property.MarketPrice / Property.Surface;
        }
    }
}
