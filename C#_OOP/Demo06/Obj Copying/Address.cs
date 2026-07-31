using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06.Obj_Copying
{
    internal class Address
    {
       

        public string City { get; set; }
        public string Country { get; set; }

        public Address(string city, string country)
        {
            City = city;
            Country = country;
        }

        public override string ToString()
        {
            return $"City : {City} - Country : {Country}";
        }

        public Address Clone()
        {
            return new Address(City, Country);
        }
    }
}
