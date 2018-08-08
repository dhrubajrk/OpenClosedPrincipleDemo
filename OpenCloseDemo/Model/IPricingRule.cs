using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloseDemo.Model
{
    public interface IPricingRule
    {
        bool IsMatch(OrderItem item);

        decimal CalculatePrice(OrderItem item);
    }
}
