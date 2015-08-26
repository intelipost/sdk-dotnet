using Intelipost.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intelipost.UnitTest
{
    /// <summary>
    /// TestConfigure é destinado a inserir as configurações de teste e torna válidas todas as requisições.
    /// </summary>
    [TestClass]
    public class TestConfigure
    {
        public TestConfigure()
        {
        }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        /// <summary>
        /// TestInitialize é destinado a inicialização da Configuração, com a API_KEY e com TRUE/FALSO para o Log.
        /// </summary>
        [TestMethod]
        public void TestInitialize()
        {
            new Configure().Initialize("8c9da3f8ecd96acb2aae0cffb47e67d8fc94706a8083238a9e83ac144a4488f2", true, "C:\\InteliPost API Log\\");
        }
    }
}