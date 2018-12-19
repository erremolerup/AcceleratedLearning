using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint3
{
   public class Program
    {
        public static void Main()
        {
            //LEVEL 1
            List<int> numbers = PrintList();
            List<int> newNumbers = MultiplyBy100AndAdd3(numbers);
            PrintNewList(newNumbers);

            new List<int> { 2, 8, 3, 11 };

            //LEVEL 2
            List<int> newOrder = ReorderList(numbers);
            PrintNewOrderList(newOrder);
            List<string> Strings = new List<string> { "a", "b", "c", "d", "e" };
            PrintNewStringOrderList(Strings);

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

        public static void DisplayList(List<int> list, string header)
        {

            // Skriv ut header i grönt
            // Skriv ut listan "list"
            throw new NotImplementedException();
        }

        public static List<int> PrintList()
        {
            WriteGreen("LISTAN");
            var input = new List<int> { 2, 8, 3, 11 };
            Console.WriteLine(String.Join(",", input));

            return input;
        }

        private static void PrintNewList(List<int> newNumbers)
        {
            WriteGreen("MULTIPLICERA MED 100 OCH LÄGG TILL TRE");

            Console.WriteLine(String.Join(",", newNumbers));

            Console.WriteLine();
        }

        private static List<int> ReorderList(List<int> numbers)
        {
            var order = new List<int> { 2, 0, 1, 3 };
            var result = order.Select(i => numbers[i]).ToList();
            return result;
        }

        private static void PrintNewOrderList(List<int> newOrder)
        {
            WriteGreen("NY ORDNING");

            Console.WriteLine(String.Join(",", newOrder));

            Console.WriteLine();
        }

        private static void PrintNewStringOrderList(List<string> strings)
        {
            var order = new List<int> { 2, 0, 1, 3, 4 };
            var result = order.Select(i => (strings[i])).ToList();
            WriteGreen("BOKSTAVSLISTA");
            Console.WriteLine(String.Join(",", strings));
            Console.WriteLine();
            WriteGreen("NY BOKSTAVSLISTA");
            Console.WriteLine(String.Join(",", result));
        }

        private static void WriteGreen(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
