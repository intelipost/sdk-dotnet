using System.Net.Configuration;
using Intelipost.API.Model;
using Intelipost.API.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Intelipost.UnitTest
{
    /// <summary>
    /// TestShipmentOrder é destinado a fazer uma requisição teste e verificar se o seu retorno está correto.
    /// </summary>
    [TestClass]
    public class TestChangeDeliveryMethod
    {
        public TestChangeDeliveryMethod()
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
        /// TestRequest é destinado a requisição teste para a validar se o retorno está correto.
        /// </summary>
        [TestMethod]
        public void TestRequest()
        {
            new TestConfigure().TestInitialize();
                        
            var vol1 = new ChangeDeliveryMethodVolumes()
            {
                VolumeNumber = "676639",
                TrackingCode = "SW123456789BR",
            };

            var vol2 = new ChangeDeliveryMethodVolumes()
            {
                VolumeNumber = "676640",
                TrackingCode = "SW123456789BR",
            };

            var volumeArrayList = new List<ChangeDeliveryMethodVolumes>();
            volumeArrayList.Add(vol1);
            volumeArrayList.Add(vol2);

            var modelRequest = new Request<ChangeDeliveryMethod>()
            {
                Content = new ChangeDeliveryMethod()
                {
                    DeliveryMethodId = 1,
                    OrderNumber = "TESTE0006",
                    QuoteId = null,
                    ClientId = 2354,
                    EstimatedDeliveryDate = new DateTime(2016, 04, 20),
                    Volumes = volumeArrayList
                }
            };

            try
            {
                var modelResponse = new API.ChangeDeliveryMethod().RequestChangeDeliveryMethod(modelRequest);
                Assert.IsFalse(modelResponse.Status == "ERROR", "Houve algum problema na requisição, por favor, verifique o Log gerado para esta resposta da requisição.");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}