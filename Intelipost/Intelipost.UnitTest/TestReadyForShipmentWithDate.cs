using Intelipost.API.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelipost.UnitTest
{
    /// <summary>
    /// TestReadyForShipmentWithDate é destinado a fazer uma requisição teste e verificar se o seu retorno está correto.
    /// </summary>
    [TestClass]
    public class TestReadyForShipmentWithDate
    {
        public TestReadyForShipmentWithDate()
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

            ReadyForShipmentWithDate[] orderArray = new ReadyForShipmentWithDate[2];
            orderArray[0] = new ReadyForShipmentWithDate()
            {
                OrderNumber = "PEDIDO-004",
                EventDate = String.Format("{0:s}", DateTime.Now)
            };

            orderArray[1] = new ReadyForShipmentWithDate()
            {
                OrderNumber = "PEDIDO-003",
                EventDate = String.Format("{0:s}", DateTime.Now)
            };

            var modelRequest = new Request<ReadyForShipmentWithDate[]>()
            {
                Content = orderArray
            };

            try
            {
                var modelResponse = new API.ReadyForShipmentWithDate().RequestNewReadyForShipmentWithDate(modelRequest);

                Assert.IsFalse(modelResponse.Status == "ERROR", "Houve algum problema na requisição, por favor, verifique o Log gerado para esta resposta da requisição.");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
