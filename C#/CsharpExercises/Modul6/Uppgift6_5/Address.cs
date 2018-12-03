using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift6_5
{
    class Address
    {
        //PROPERTIES --> kortkommando prop
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int ZipCode = 0; //{ get; set; }

        //METHODS
        public string GetFullStreet()
        {
            return Street + "  " + StreetNumber;
            //return fullStreet;
        }

        
        public void SetZipCode(int z)
        {
            if (z. )
            {
                ZipCode = z;
            }
        }

        //GETTER 1
        //public string FullStreet
        //{
        //    get
        //    {
        //        return Street + StreetNumber;
        //    }
        //}

        //GETTER 2
        public string FullStreet => Street + " " + StreetNumber;
    }
}