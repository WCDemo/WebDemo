using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebDemo.Models;

namespace WebDemoMSTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var i = new ImportantClass();

            var nr = i.Add(2, 2);

            Assert.AreEqual(4, nr);
        }
    }
}
