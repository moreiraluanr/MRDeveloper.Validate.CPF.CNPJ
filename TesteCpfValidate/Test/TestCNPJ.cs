using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackageValidateCpf.Entities;

namespace TestValidate.Test
{
    [TestClass]
    public class TestCNPJ
    {
        private string CnpjValid;

        private string CnpjInvalid;

        public TestCNPJ()
        {
            CnpjValid = "26.933.867/0001-93";
            CnpjInvalid = "99.999.999/9999-99";
        }

        [TestMethod]
        public void RetornaTrueSeCnpjForValido()
        {
            Assert.AreEqual(true, new CNPJ().Validate(CnpjValid));
        }

        [TestMethod]
        public void RetornaFalseSeCnpjForInvalido()
        {
            Assert.AreEqual(false, new CNPJ().Validate(CnpjInvalid));
        }
    }
}
