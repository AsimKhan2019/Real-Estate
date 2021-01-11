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

        [Test]
        public void ComputeAssetAppreciationTest()
        {
            var asset = new Asset();
            var pricer = asset.GetPricer();
            Assert.IsNotNull(pricer);

            var appreciation = pricer.ComputeAppreciation();
            Assert.AreEqual(appreciation, 0.0);

            asset.PurchasePrice = 1000;
            asset.CurrentValue = 1450;
            appreciation = pricer.ComputeAppreciation();

            Assert.AreEqual(appreciation, 450);
        }
    }
}