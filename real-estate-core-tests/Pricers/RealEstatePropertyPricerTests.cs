using NUnit.Framework;
using RealEstate.Core.Assets;
using RealEstate.Core.Pricers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate.Core.Tests.Pricers
{
    public class RealEstatePropertyPricerTests
    {
        [Test]
        public void ComputePricePerSurfaceTest()
        {
            var property = new RealEstateProperty();
            var pricer = property.GetPricer() as RealEstatePropertyPricer;
            Assert.IsNotNull(pricer);

            var price = pricer.ComputeMarketPricePerSurface();
            Assert.AreEqual(price, 0.0);

            property.Surface = 1e2;
            property.MarketPrice = 1e6;
            price = pricer.ComputeMarketPricePerSurface();

            Assert.AreEqual(price, 1e4);
        }

        [Test]
        public void CashInTest()
        {
            var property = new RealEstateProperty();
            var pricer = property.GetPricer() as RealEstatePropertyPricer;

            property.Rent = 100;
            var yearlyCashIn = pricer.ComputeYearlyCashIn();

            Assert.AreEqual(yearlyCashIn, 1200);
        }
    }
}
