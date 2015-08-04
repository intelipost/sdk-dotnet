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
            new Configure().Initialize("dc1c35f1c3a3d37426ef581d8eafe7f1536a505e36f374828e7d05036ab009d0", true, "C:\\InteliPost API Log\\");
        }
    }
}