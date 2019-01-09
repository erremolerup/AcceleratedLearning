using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Uppgift6_5
{
    class Address
    {
        private string zippis;

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

        public void SetZipCode(string newvalue)
        {
            string okZipCodePattern = @"^\d\d\d \d\d$";
            if (Regex.IsMatch(newvalue, okZipCodePattern))
            {
                zippis = newvalue;
            }
        }
        public string GetZipCode()
        {
            return zippis;
        }
    }

}
