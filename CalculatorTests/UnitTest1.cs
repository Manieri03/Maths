using MethodsLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class TestMaths
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            double r = BasicMaths.Add(10, 10);
            Assert.AreEqual(r, 20);
        }

        [TestMethod]
        public void Test_SubstractMethod()
        {
            double r = BasicMaths.Substract(10, 10);
            Assert.AreEqual(r, 0);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            double r = BasicMaths.Divide(10, 5);
            Assert.AreEqual(r, 2);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            double r = BasicMaths.Multiply(10, 10);
            Assert.AreEqual(r, 100);
        }
    }
}
