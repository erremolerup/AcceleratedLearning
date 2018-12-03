using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint01
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersTogether = AskUserForNumbers();
            List<int> listOfNumbers = CreateArrayOfNumbers(numbersTogether);
            DrawTriangle(listOfNumbers);
        }

        //GET LIST OF NUMBERS FROM USER
        private static string AskUserForNumbers()
        {
            Console.Write("Write command: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string numbersTogether = Console.ReadLine();

            return numbersTogether;
        }

        //CREATE LIST AND PARSE TO INT
        private static List<int> CreateArrayOfNumbers(string numbersTogether)
        {
            string[] numbers = numbersTogether.Split(new[] { '-' });

            List<int> listOfNumbers = new List<int>();
            int x;

            foreach (var number in numbers)
            {
                x = int.Parse(number);
                listOfNumbers.Add(x);
            }

            return listOfNumbers;
            
        }

        //REPORT TO USER
        private static void DrawTriangle(List<int> listOfNumbers)
        {
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var number in listOfNumbers)
            {
                Console.WriteLine();

                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("*");
                }
                Console.WriteLine();

            }

        }        
    }
}

