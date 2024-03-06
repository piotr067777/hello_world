using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyStringTest()
        {
            Assert.AreEqual(StringCalculator.Calculate(""), 0);
        }

        [TestMethod]
        public void SingleValueTest()
        {
            Assert.AreEqual(StringCalculator.Calculate("-1"), -1);
            Assert.AreEqual(StringCalculator.Calculate("24"), 24);
            Assert.AreEqual(StringCalculator.Calculate("0"), 0);
            Assert.AreEqual(StringCalculator.Calculate("2137"), 2137);
        }
    }
}
