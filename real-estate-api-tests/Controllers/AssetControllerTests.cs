using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using RealEstate.Core.Assets;
using RealEstate.Api.Controllers;

namespace RealEstate.Api.Tests
{
    public class AssetControllerTests
    {
        [Test]
        public void GetTest()
        {
            var list = new List<Asset>();
            list.Add(new Asset());
            var loader = new FakeListLoader<Asset>(list);

            var controller = new AssetController(null, loader);
            var returnedList = controller.Get();

            Assert.AreEqual(1, returnedList.Count()); 
        }
    }
}