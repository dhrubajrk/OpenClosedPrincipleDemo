using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloseDemo.Model
{
    public class Address
    {
        public string Name { get; set; }

        public string AddressLine1 { get; set; }

        public string AdressLine2 { get; set; }

        public long ZipCode { get; set; }

        public Address()
        {

        }

        public Address(string name, string addressLine1, string addressLine2, long zipCode)
        {
            Name = name;
            AddressLine1 = addressLine1;
            AdressLine2 = addressLine2;
            ZipCode = zipCode;
        }
    }
}
