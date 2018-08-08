using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCloseDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderTest
{
    [TestClass]
    public class WeightPriceRuleTest
    {
        [TestMethod]
        public void WeightPriceRuleCaculatePriceTest()
        {
            OrderItem item = new OrderItem("Brinjals", 4, 3.5m, "WeightPrice");
            EachPriceRule eachPriceRule = new EachPriceRule();
            var actual = eachPriceRule.CalculatePrice(item);

            var expected = 14m;

            Assert.AreEqual(actual, expected);
        }
    }
}
