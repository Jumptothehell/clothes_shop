using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clothes_shop
{
    class Address
    {
        public string street;
        public string city;
        public string zipcode;

        public Address(string nm_street, string nm_city, string citycode)
        {
            street = nm_street;
            city = nm_city;
            zipcode = citycode;
        }
    }
}
