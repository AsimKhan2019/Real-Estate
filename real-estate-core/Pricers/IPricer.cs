using RealEstate.Core.Assets;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate.Core.Pricers
{
    public interface IPricer
    {
        public double ComputeRoi();
        public double ComputeYearlyCashIn();
        public double ComputeYearlyCashOut();

    }
}
