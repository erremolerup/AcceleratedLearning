using System;
using System.Collections.Generic;

namespace RepetitionCheckpoint3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = PrintNumbersList();
            List<int> changedNumbers = MultiplyBy100AndAdd3(numbers);
            PrintChangedNumbers(changedNumbers);
        }


        private static List<int> PrintNumbersList()
        {
            WriteInGreen("LISTAN");
            var input = new List<int> { 2, 8, 3, 11};

            Console.WriteLine(String.Join(", ", input));
            return input;
        }

        private static List<int> MultiplyBy100AndAdd3(List<int> numbers)
        {
            var newNumbers = new List<int>();
            foreach (var number in numbers)
            {
                int newNumber = number * 100 + 3;
                newNumbers.Add(newNumber);
            }
            return newNumbers;
        }        

        private static void WriteInGreen(string v)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(v);
            Console.ResetColor();
        }

        private static void PrintChangedNumbers(List<int> changedNumbers)
        {
            WriteInGreen("NYA LISTAN");
            Console.WriteLine(String.Join(", ", changedNumbers));
        }
    }
}
