using BasicCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicCacluatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Addition(5, 4);
            Assert.AreEqual(9, result);
        }
    }
}
