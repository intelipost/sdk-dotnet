﻿using System.Net.Configuration;
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
    public class TestShipmentOrder
    {
        public TestShipmentOrder()
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

            var endCustomer = new EndCustomer()
            {
                FirstName = "Unit",
                LastName = "Test",
                Email = "teste@teste.com",
                Phone = "00231424551",
                Cellphone = "11999999999",
                IsCompany = false,
                FederalTaxPayerId = "44611341801",
                StateTaxPayerId = "2314234",
                ShippingAddress = "Avenida Paulista",
                ShippingNumber = "2",
                ShippingAdditional = "apto 202",
                ShippingReference = "mercado test",
                ShippingQuarter = "Consolação",
                ShippingCity = "São Paulo",
                ShippingState = "São Paulo",
                ShippingZipCode = "01311330",
                ShippingCountry = "BR"
            };

            var volumeArray1 = new ShipmentOrderVolumeArray()
            {
                ShipmentOrderVolumeNumber = "1",
                Weight = 10.2,
                Width = 10.2,
                Height = 10.2,
                Length = 10.2,
                ProductsNature = "beverages",
                ProductsQuantity = 2,
                IsIcmsExempt = false,
                TrackingCode = "SW123456789BR",
                VolumeTypeCode = "box",
                ShipmentOrderVolumeInvoice = new ShipmentOrderVolumeInvoice()
                {
                    InvoiceSeries = "1",
                    InvoiveNumber = "1000",
                    InvoiceKey = "41140502834982004563550010000084111000132317",
                    InvoiceDate = new DateTime(2015, 08, 20),
                    InvoiceTotalValue = "45.99",
                    InvoiceProductsValue = "39.99",
                    InvoiceCfop = "2890"
                },


            };

            var volumeArray2 = new ShipmentOrderVolumeArray()
            {
                ShipmentOrderVolumeNumber = "2",
                Weight = 10.2,
                Width = 10.2,
                Height = 10.2,
                Length = 10.2,
                ProductsNature = "beverages",
                ProductsQuantity = 2,
                IsIcmsExempt = false,
                TrackingCode = "SW123456789BR",
                VolumeTypeCode = "box",
                ShipmentOrderVolumeInvoice = new ShipmentOrderVolumeInvoice()
                {
                    InvoiceSeries = "1",
                    InvoiveNumber = "1000",
                    InvoiceKey = "41140502834982004563550010000084111000132317",
                    InvoiceDate = new DateTime(2015, 08, 20),
                    InvoiceTotalValue = "45.99",
                    InvoiceProductsValue = "39.99",
                    InvoiceCfop = "2890"
                },
            };

            var volumeArrayList = new List<ShipmentOrderVolumeArray>();
            volumeArrayList.Add(volumeArray1);
            volumeArrayList.Add(volumeArray2);

            var additionalInformation = new Dictionary<string, string>();
            additionalInformation.Add("key", "val1");
            additionalInformation.Add("key2", "val2");

            var externalOrderNumbers = new Dictionary<string, string>();
            externalOrderNumbers.Add("marketplace", "PEDIDO-MKT-030");

            var modelRequest = new Request<ShipmentOrder>()
            {
                Content = new ShipmentOrder()
                {
                    DeliveryMethodId = 1,
                    OrderNumber = "PEDIDO-013",
                    SalesOrderNumber = "s-sdk0002",
                    SalesChannel = "SC Teste",
                    QuoteId = null,
                    OriginZipCode = "22710440",
                    OriginWarehouseCode = "CD01",
                    //EstimatedDeliveryDate = new DateTime(2015,08,20),
                    EndCustomer = endCustomer,
                    ShipmentOrderVolumeArray = volumeArrayList,
                    ShipmentOrderType = "NORMAL",
                    CustomerShippingCosts = 1,
                    Scheduled = false,
                    Created = new DateTime(2018, 05, 02),
                    AdditionalInformation = additionalInformation,
                    ExternalOrderNumbers = externalOrderNumbers
                }
            };

            try
            {
                var modelResponse = new API.ShipmentOrder().RequestNewShipmentOrder(modelRequest);
                Assert.IsFalse(modelResponse.Status == "ERROR", "Houve algum problema na requisição, por favor, verifique o Log gerado para esta resposta da requisição.");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}