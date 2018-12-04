using System;
using System.Text.RegularExpressions;

namespace Uppgift8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            string animalString = AskForAnimals();

            try
            {
                string[] animals = ParseAnimals(animalString);
                PrintAnimals(animals);
                break;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }

            }
        }

        private static string AskForAnimals()
        {
            Console.Write("Enter a list of animals: ");

            Console.ForegroundColor = ConsoleColor.Green;
            string animalString = Console.ReadLine();
            return animalString;
        }

        private static string[] ParseAnimals(string animalString)
        {
            //if (string.IsNullOrWhiteSpace) men måste då använda en bool
            if (animalString.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new ArgumentException("Animal string does not contain any letters");
            }

            string[] animals = animalString.Split(',');

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] = animals[i].Trim();
            }
            foreach (var animal in animals)
            {
                if (animalString.Length > 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException($"{animal} contains too many letters!");
                }
            }

            foreach (var animal in animals)
            {
                Regex reg = new Regex(@"^[a-zåäöA-ZÅÄÖ]+$");

                if (!reg.Match(animal).Success)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException($"Animal {animal} contains invalid letters");
                }

            }
            Console.WriteLine();
            return animals;
        }

        private static void PrintAnimals(string[] animals)
        {
            Console.WriteLine($"There are {animals.Length} animals in the list.");
            Console.WriteLine();
        }
    }
}
