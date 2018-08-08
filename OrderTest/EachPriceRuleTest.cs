using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCloseDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderTest
{
    [TestClass]
    public class EachPriceRuleTest
    {
        [TestMethod]
        public void EachPriceRuleCaculatePriceTest()
        {
            OrderItem item = new OrderItem("Pencils", 4, 3.5m, "EachPrice");
            EachPriceRule eachPriceRule = new EachPriceRule();
            var actual = eachPriceRule.CalculatePrice(item);

            var expected = 14m;

            Assert.AreEqual(actual, expected);
        }
    }
}
