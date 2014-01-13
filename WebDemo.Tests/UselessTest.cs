using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Assert.IsTrue(false);
            }
        }
    }
}
