using Intelipost.API;
using Intelipost.API.Model;
using Intelipost.API.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Intelipost.UnitTest
{
    /// <summary>
    /// TestQuote é destinado a fazer uma cotação teste e verificar se o seu retorno está correto.
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

        /// <summary>
        /// TestRequest é destinado a requisição teste para a cotação.
        /// </summary>
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
                VolumeType = VolumeType.Envelope,
                Weight = 10,
                Width = 10
            };

            var volume2 = new Volume()
            {
                CostOfGoods = 30.99,
                Height = 10,
                Length = 25,
                VolumeType = VolumeType.Box,
                Weight = 2,
                Width = 20
            };

            volumes.Add(volume1);
            volumes.Add(volume2);

            var modelRequest = new Request()
            {
                OriginZipCode = "01001-000",
                DestinationZipCode = "20000-000",
                Volumes = volumes
            };

            try
            {
                var modelResponse = new Quote().Request(modelRequest);

                Assert.IsFalse(modelResponse.Status == "ERROR", "Houve algum problema na requisição, por favor, verifique o Log gerado para esta resposta da requisição.");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}