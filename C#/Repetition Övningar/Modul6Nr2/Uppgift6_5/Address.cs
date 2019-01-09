using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift6_5
{
    class Address
    {
        //Properties
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }

        public string GetFullStreet()
        {
            return Street + " " + StreetNumber;
        }

        public string FullStreet => Street + " " + StreetNumber;
    }

}
