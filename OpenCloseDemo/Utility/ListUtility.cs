using OpenCloseDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloseDemo.Utility
{
    public static class ListUtility
    {
        public static bool FirstOf(this IPricingRule priceRule, OrderItem item)
        {
            return priceRule.IsMatch(item);
        }
    }
}
