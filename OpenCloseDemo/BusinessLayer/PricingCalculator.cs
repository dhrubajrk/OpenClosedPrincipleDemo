using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OpenCloseDemo.Model
{
    public class PricingCalculator
    {
        private List<IPricingRule> _PricingRules;

        public PricingCalculator()
        {
            _PricingRules = new List<IPricingRule>();
            _PricingRules.Add(new EachPriceRule());
            _PricingRules.Add(new WeightPriceRule());
            _PricingRules.Add(new B2G1FreeRule());
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return _PricingRules.First(pricingRule => pricingRule.IsMatch(item)).CalculatePrice(item);
        }
    }
}
