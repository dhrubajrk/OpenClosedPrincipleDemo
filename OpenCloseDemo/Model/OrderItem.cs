using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloseDemo.Model
{
    public class OrderItem
    {
        public int Quantity { get; set; }

        public readonly string _ItemName;

        public decimal Price { get; set; }

        public string Measure { get; set; }

        public OrderItem(string name, int quantity, decimal price, string measure)
        {
            _ItemName = name;
            Quantity = quantity;
            Price = price;
            Measure = measure;
        }

    }
}
