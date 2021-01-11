using RealEstate.Core.Assets;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate.Core.Pricers
{
    public class AssetPricer : IPricer
    {
        protected IAsset Asset;
        public AssetPricer() { }

        public AssetPricer(IAsset asset) 
        {
            Asset = asset;
        }

        public double ComputeRoi()
        {
            return 0.0;
        }

        public double ComputeAppreciation()
        {
            return Asset.CurrentValue - Asset.PurchasePrice;
        }
        public virtual double ComputeYearlyCashIn()
        {
            return 0.0;
        }

        public virtual double ComputeYearlyCashOut()
        {
            return 0.0;
        }
    }
}
