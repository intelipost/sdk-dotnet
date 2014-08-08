using System.Collections.Generic;
using Intelipost.API;
using Intelipost.Model;
using Intelipost.Util.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intelipost.UnitTest
{
    /// <summary>
    /// Summary description for TestQuote
    /// </summary>
    [TestClass]
    public class TestQuote
    {
        public TestQuote()
        {
        }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void TestRequest()
        {
            new TestConfigure().TestIntialize();

            var volumes = new List<Volume>();
            var volume1 = new Volume()
            {
                CostOfGoods = 15.99,
                Height = 10,
                Length = 25,
                VolumeType = VolumeType.ENVELOPE,
                Weight = 10,
                Width = 10
            };

            var volume2 = new Volume()
            {
                CostOfGoods = 30.99,
                Height = 10,
                Length = 25,
                VolumeType = VolumeType.BOX,
                Weight = 2,
                Width = 20
            };

            volumes.Add(volume1);
            volumes.Add(volume2);

            var modelRequest = new Model.Request()
            {
                OriginZipCode = "01001-000",
                DestinationZipCode = "20000-000",
                Volumes = volumes
            };

            new Quote().Request(modelRequest);
        }
    }
}
