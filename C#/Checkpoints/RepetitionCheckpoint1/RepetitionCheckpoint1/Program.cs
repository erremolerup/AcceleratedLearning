using System;
using System.Collections.Generic;

namespace RepetitionCheckpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersTogether = EnterNumbers();
            List<int> listOfNumbers = CreateArrayOfNumbers(numbersTogether);
            DrawTriangles(listOfNumbers);
        }

        private static string EnterNumbers()
        {
            Console.Write("Write command: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string numbers = Console.ReadLine();
            return numbers;
        }

        private static List<int> CreateArrayOfNumbers(string numbersTogether)
        {
            // gör linq
            string[] numbers = numbersTogether.Split('-');

            List<int> listOfNumbers = new List<int>();
            int x;

            foreach (var number in numbers)
            {
                x = int.Parse(number);
                listOfNumbers.Add(x);
            }
            return listOfNumbers;
        }

        private static void DrawTriangles(List<int> listOfNumbers)

        {
            Console.ForegroundColor = ConsoleColor.White;
            

            foreach (var number in listOfNumbers)
            {
                Console.WriteLine();
                for (int i = 1; i <= number; i++)
                {
                    for (int k = 1; k <= i; k++)
                    {
                    Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            Console.WriteLine();
        }
    }
}
