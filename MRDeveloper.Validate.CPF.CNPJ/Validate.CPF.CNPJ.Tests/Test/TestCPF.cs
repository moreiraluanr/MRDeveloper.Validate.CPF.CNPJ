using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackageValidateCpf;

namespace TestValidate.Test
{
    [TestClass]
    public class TestCPF
    {
        private string CpfValid;

        private string CpfInvalid;

        public TestCPF()
        {
            CpfValid = "65337471007";
            CpfInvalid = "12345678901";
        }

        [TestMethod]
        public void RetornaTrueSeCpfForValido()
        {
            Assert.AreEqual(true, new CPF().Validate(CpfValid));
        }

        [TestMethod]
        public void RetornaFalseSeCpfForInvalido()
        {
            Assert.AreEqual(false, new CPF().Validate(CpfInvalid));
        }
    }
}
