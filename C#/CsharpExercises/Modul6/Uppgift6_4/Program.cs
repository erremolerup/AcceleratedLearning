using System;

namespace Uppgift6_4
{
    public class Program
    {

        static void Main(string[] arg)
        {
            //INSTANCE
            var Lisa = new Person
            {
                FirstName = "Lisa",
                LastName = "Larsson",
                BirthDay = new DateTime(1991, 7, 15),
                FavoriteSport = Sport.hurling,
                Gender = DifferentGenders.female
            };

            //Print info about Lisa
            Console.WriteLine($"Lisa is {Lisa.Gender.ToString().ToLower()}");
            Console.WriteLine($"Lisa likes to {Lisa.FavoriteSport.ToString().ToLower()}");

            if (Lisa.FavoriteSport == Sport.rugby)
            {
                Console.WriteLine("Lisa likes rugby");
            }
            else
            {
                Console.WriteLine("Lisa doesn't like to play rugby");
            }

            Console.WriteLine();

            Console.Write("Enter a sport: ");
            Console.ReadLine();
            //if ( == Sport.hurling)
            {
                Console.WriteLine("Oh I know hurling!");
            }

            Console.WriteLine();
        }

    }

}
