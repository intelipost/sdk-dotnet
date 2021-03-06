﻿using System.Net.Configuration;
using Intelipost.API.Model;
using Intelipost.API.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Intelipost.UnitTest
{
    /// <summary>
    /// TestQuote é destinado a fazer uma requisição teste e verificar se o seu retorno está correto.
    /// </summary>
    [TestClass]
    public class TestQuoteByProduct
    {
        public TestQuoteByProduct()
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

            Products produto1 = new Products() {
                Weight = 1,
                CostOfGoods = 2,
                Width = 0.1,
                Height = 0.1,
                Length = 0.1,
                Quantity = 1,
                SkuId = "123",
                description = "produto 1",
                ProductCategory = "cat01",
                CanGroup = false
            };

            Products produto2 = new Products()
            {
                Weight = 1,
                CostOfGoods = 2,
                Width = 0.1,
                Height = 0.1,
                Length = 0.1,
                Quantity = 1,
                SkuId = "123",
                description = "produto 1",
                ProductCategory = "cat01",
                CanGroup = false
            };

            List<Products> produtos = new List<Products>();
            produtos.Add(produto1);
            produtos.Add(produto2);





            var modelRequest = new Request<Quote>()
            {
                Content = new Quote()
                {
                    OriginZipCode = "01001-000",
                    DestinationZipCode = "20000-000",
                    Products = produtos,
                    AddtionalInformation = new AddtionalInformation() {
                        FreeShipping = false,
                        ExtraCostsAbsolute = 0,
                        ExtraCostsPercentage = 0,
                        LeadTimeBussinessDays = 0,
                        DeliveryMethodIds = new int[] { 1, 2 },
                        ShippedDate = (DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString()).ToString()
                    }        
                }
            };

            try
            {
                var modelResponse = new API.QuoteByProduct().RequestNewQuoteByProduct(modelRequest, "8c9da3f8ecd96acb2aae0cffb47e67d8fc94706a8083238a9e83ac144a4488f2");

                Assert.IsFalse(modelResponse.Status == "ERROR", "Houve algum problema na requisição, por favor, verifique o Log gerado para esta resposta da requisição.");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}