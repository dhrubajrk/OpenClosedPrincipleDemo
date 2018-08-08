using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCloseDemo.Model;

namespace OrderTest
{
    [TestClass]
    public class B2G1FreeTest
    {
        [TestMethod]
        public void Buy2Get1FreeTest()
        {
            OrderItem item = new OrderItem("Pencils", 4, 3.5m, "B2G1Free");
            B2G1FreeRule b2G1FreeRule = new B2G1FreeRule();
            var actual = b2G1FreeRule.CalculatePrice(item);

            var expected = 10.5m;

            Assert.AreEqual(actual, expected);
        }
    }
}
