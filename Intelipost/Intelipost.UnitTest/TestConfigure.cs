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
        public void TestIntialize()
        {
            new Configure().Initialize("c5ceacc445054db3109aca7ef99240bb1e1fa1842d90be22594caeba6d55558e", true);
        }
    }
}