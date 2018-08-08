using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloseDemo.Model
{
    public class Order
    {
        public List<OrderItem> OrderItems;

        public Address ShippingAddress;

        public decimal PayableAmount { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
            ShippingAddress = new Address();
        }

        public void AddItem(string name, int quantity, decimal price, string measure)
        {
            OrderItems.Add(new OrderItem(name, quantity, price, measure));
        }

        public void DisplayOrderDetails()
        {

        }
    }
}
