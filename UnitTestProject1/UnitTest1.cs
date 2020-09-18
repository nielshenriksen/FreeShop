using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cl = new ClassLibrary1.Class1();

            var num = cl.Add(1, 2);

            Assert.AreEqual(3, num);
        }
    }
}
