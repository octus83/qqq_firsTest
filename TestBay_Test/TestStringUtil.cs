using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestBay.Utils;

namespace TestBay_Test
{
    [TestClass]
    public class TestStringUtils
    {
        [TestMethod]
        public void StringUtil_GetStringBetween()
        {
            Assert.AreEqual("something", StringUtil.GetStringBetween("a", "b", "1a2345b678"));
        }
    }
}
