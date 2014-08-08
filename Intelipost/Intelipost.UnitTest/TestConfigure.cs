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

        [TestMethod]
        public void TestIntialize()
        {
            new Configure().Initialize("d0a3b5f355e17333de5c9a15d665f3d7724b4246540012d5eb851a82db1b95a5", true);
        }
    }
}