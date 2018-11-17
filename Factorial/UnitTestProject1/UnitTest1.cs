using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factorial;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Calculator.FactorialOf(5), 120);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Calculator.FactorialOf(0), 1);
        }
    }
}
