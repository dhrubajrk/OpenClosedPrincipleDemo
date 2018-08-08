using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloseDemo.Model
{
    public class WeightPriceRule : IPricingRule
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Measure.StartsWith("WeightPrice");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return item.Quantity * item.Price;
        }
    }
}
