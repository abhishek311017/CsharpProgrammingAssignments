using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NormalForTest;

namespace UnitTestNormalForTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AddTest p = new AddTest();
            Assert.AreEqual(3, p.Add());
        }
    }
}
