using NUnit.Framework;
using RealEstate.Core.Assets;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate.Core.Tests.Assets
{
    public class RealEstatePropertyTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsRealEstatePropertyAssetTest()
        {
            var property = new RealEstateProperty();
            var isAsset = property is IAsset;
            Assert.AreEqual(isAsset, true);
        }
    }
}
