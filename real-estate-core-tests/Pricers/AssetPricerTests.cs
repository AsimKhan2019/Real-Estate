using NUnit.Framework;
using RealEstate.Core.Assets;
using RealEstate.Core.Pricers;

namespace RealEstate.Core.Tests.Pricers
{
    public class AssetPricerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ComputeAssetRoiTest()
        {
            var asset = new Asset();
            var pricer = asset.GetPricer();
            Assert.IsNotNull(pricer);
            
            var roi = pricer.ComputeRoi();
            Assert.AreEqual(roi, 0.0);

            var cashIn = pricer.ComputeYearlyCashIn();
            Assert.AreEqual(cashIn, 0.0);
        }
    }
}