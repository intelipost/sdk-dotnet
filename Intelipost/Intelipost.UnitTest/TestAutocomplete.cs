using System.Net.Configuration;
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
    public class TestAutocomplete
    {       
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
            new TestConfigure().TestInitialize();
            try
            {
                var modelResponse = new API.AutoComplete().RequestAutoComplete("09932220");      
                Assert.IsFalse(modelResponse.Status == "ERROR", "Houve algum problema na requisição, por favor, verifique o Log gerado para esta resposta da requisição.");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}