using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloseDemo.Model
{
    public class B2G1FreeRule : IPricingRule
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Measure.StartsWith("B2G1Free");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            var result =  item.Quantity * item.Price;
            result -= (item.Quantity / 3) * item.Price;
            return result;
        }
    }
}
