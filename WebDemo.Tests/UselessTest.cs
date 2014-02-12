using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDemo.Models;

namespace WebDemo.Tests
{
    public class UselessTest
    {
        [TestFixture]
        public class TestClass
        {
            [TestCase]
            public void AddTest()
            {
                var i = new ImportantClass();

                var nr = i.Add(2, 5);

                Assert.AreEqual(4, nr);
            }
        }
    }
}
