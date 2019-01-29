using System;
using System.Collections.Generic;

namespace RepetitionCheckpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersTogether = EnterNumbers();
            List<int> listOfANumbers = CreateArrayOfANumbers(numbersTogether);
            List<int> listOfBNumbers = CreateArrayOfBNumbers(numbersTogether);
            DrawATriangles(listOfANumbers);
            DrawBTriangles(listOfBNumbers);
            Console.ReadKey();
        }


        private static string EnterNumbers()
        {
            Console.Write("Write command: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string numbers = Console.ReadLine();
            return numbers;
        }

        private static List<int> CreateArrayOfANumbers(string numbersTogether)
        {
            string[] numbers = numbersTogether.Split('-');

            List<int> listOfANumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number.Contains("A"))
                {
                    string part1 = number.Substring(0, 1);
                    string part2 = number.Substring(1, 1);
                    int parsedPart2 = int.Parse(part2);
                    listOfANumbers.Add(parsedPart2);
                }
            }
            return listOfANumbers;
        }

        private static List<int> CreateArrayOfBNumbers(string numbersTogether)
        {
            string[] numbers = numbersTogether.Split('-');

            List<int> listOfBNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number.Contains("B"))
                {
                    string part1 = number.Substring(0, 1);
                    string part2 = number.Substring(1, 1);
                    int parsedPart2 = int.Parse(part2);
                    listOfBNumbers.Add(parsedPart2);
                }
            }
            return listOfBNumbers;
        }

        private static void DrawATriangles(List<int> listOfANumbers)
        {
            Console.ForegroundColor = ConsoleColor.White;


            foreach (var number in listOfANumbers)
            {
                Console.WriteLine();
                for (int y = 0; y <= number; y++)
                {
                    WriteStars(y);
                }
            }
            Console.WriteLine();
        }

        private static void DrawBTriangles(List<int> listOfBNumbers)
        {
            Console.ForegroundColor = ConsoleColor.White;


            foreach (var number in listOfBNumbers)
            {
                Console.WriteLine();
                for (int y = number; y >= 1; y--)
                {
                    WriteStars(y);
                }
            }
            Console.WriteLine();
        }

        private static void WriteStars(int numberOfStars)
        {
            for (int x = 1; x <= numberOfStars; x++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}
