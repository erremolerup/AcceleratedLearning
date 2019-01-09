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
                string animalsString = AskUserForAnimals();

                try
                {
                    string[] animals = ParseAnimals(animalsString);
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

        private static string AskUserForAnimals()
        {
            Console.Write("Enter a list of animals: ");

            Console.ForegroundColor = ConsoleColor.Green;
            string animals = Console.ReadLine();
            return animals;
        }

        private static string[] ParseAnimals(string animalsString)
        {
            if (animalsString.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new ArgumentException("Animal string does not contain any letters!");
            }

            string[] animals = animalsString.Split(',');

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] = animals[i].Trim();
            }

            foreach (var animal in animals)
            {
                if (animalsString.Length > 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException($"'{animal}' has too many letters");
                }
            }

            foreach (var animal in animals)
            {
                Regex reg = new Regex(@"^[a-zåäöA-ZÅÄÖ+$]");

                if (!reg.Match(animal).Success)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException($"'{animal}' contains invalid letters");
                }
            }
            Console.WriteLine();
            return animals;
        }

        private static void PrintAnimals(string[] animals)
        {
            Console.WriteLine($"There are {animals.Length} animals in the list");
            Console.WriteLine();
        }


    }
}
