﻿using System.Net.Configuration;
using Intelipost.API.Model;
using Intelipost.API.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Intelipost.UnitTest
{
    /// <summary>
    /// TestInfo é destinado a fazer uma requisição teste e verificar se o seu retorno está correto.
    /// </summary>
    [TestClass]
    public class TestInfo
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
        /// TestRequest é destinado a requisição teste para a validar se o retorno está correto.
        /// </summary>
        [TestMethod]
        public void TestRequest()
        {
            new TestConfigure().TestInitialize();
            try
            {
                var modelResponse = new API.Info().RequestInfo();      
                Assert.IsFalse(modelResponse.Status == "ERROR", "Houve algum problema na requisição, por favor, verifique o Log gerado para esta resposta da requisição.");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}