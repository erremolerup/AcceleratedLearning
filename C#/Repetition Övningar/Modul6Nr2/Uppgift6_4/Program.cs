using System;

namespace Uppgift6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo();
            CreateListOfSports();
            EnterASport();
        }

        private static void EnterASport()
        {
            Console.Write("Enter a sport: ");
            Console.ForegroundColor = ConsoleColor.Green;
            var input = Console.ReadLine();
            Console.ResetColor();

            if (input == "hurling")
            {
                Console.WriteLine("Oh, I know hurling!");
            }
            else if (input == "badminton")
            {
                Console.WriteLine("Oh, I know badminton!");
            }
        }

        private static void CreateListOfSports()
        {
           
        }

        private static void PrintInfo()
        {
            //Instance
            var Lisa = new Person
            {
                FirstName = "Lisa",
                LastName = "Lisasson",
                BirthDay = new DateTime(1991, 3, 17),
                FavoriteSport = Sport.tennis,
                Gender = Gender.female
            };

            //Print info about Lisa
            Console.WriteLine($"Lisa is {Lisa.Gender.ToString()}");
            Console.WriteLine($"Lisa likes to play {Lisa.FavoriteSport.ToString()}");

            if (Lisa.FavoriteSport == Sport.soccer)
            {
                Console.WriteLine("Lisa likes rugby");
            }
            else
            {
                Console.WriteLine("Lisa doesn't like to play rugby");
            }
        }
    }
}
