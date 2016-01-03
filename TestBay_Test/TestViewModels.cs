using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBay.Utils;
using TestBay.Views;

namespace TestBay_Test
{
    [TestClass]
    public class TestViewModels
    {
        [TestMethod]
        public void TestFirstViewModel()
        {
            Assert.AreEqual("FirstView", First_View.GetViewName());
        }
    } 
}
