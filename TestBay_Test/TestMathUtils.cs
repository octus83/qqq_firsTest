using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBay.Utils;

namespace TestBay_Test
{
    [TestClass]
    public class TestMathUtils
    {
        [TestMethod]
        public void MathUtil_TestIncrement()
        {
            int baseValue = 10;
            int expectedValue = baseValue - 1;

            int result = MathUtil.Increment(baseValue);

            Assert.AreEqual(expectedValue, result);
        }
    }
}
