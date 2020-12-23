using NUnit.Framework;
using RealEstate.Core.Assets;
using RealEstate.Core.Pricers;

namespace RealEstate.Core.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ComputeAssetRoiTest()
        {
            var asset = new Asset();
            var roi = asset.GetPricer().ComputeRoi(asset);
            Assert.AreEqual(roi, 0.0);
        }
    }
}