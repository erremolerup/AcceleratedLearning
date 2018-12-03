using System;

namespace Uppgift6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANCE
            var street1 = new Address
            {
                Street = "Kulpetorpsvägen",
                StreetNumber = 13,
                City = "Hålta",
                ZipCode = 44295
            };

            var street2 = new Address
            {
                Street = "Gyllenkrooksgatan",
                StreetNumber = 1,
                City = "Göteborg",
                ZipCode = 
            };

            Console.WriteLine($"Street".PadRight(20) + street1.Street);
            Console.WriteLine($"StreetNumber".PadRight(20) + street1.StreetNumber);
            Console.WriteLine($"City".PadRight(20) + street1.City);
            Console.WriteLine($"ZipCode".PadRight(20) + street1.ZipCode);
            Console.WriteLine($"FullStreet".PadRight(20) + street1.FullStreet);
            Console.WriteLine();
        }
    }
}
