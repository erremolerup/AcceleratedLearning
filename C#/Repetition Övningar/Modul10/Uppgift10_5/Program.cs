using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Uppgift10_5
{
    class Program
    {
        static string userInput;
        static int id;
        static string product;

        static Dictionary<int, string> dic = new Dictionary<int, string>();

        static void Main(string[] args)
        {
            Dictionary<int, string> dic = CreateDictionary();
            Console.WriteLine();
            PrintProductDictionary(dic);
            Console.WriteLine();
        }

        private static Dictionary<int, string> CreateDictionary()
        {
            while (true)
            {
                Console.Write("Enter product ID and name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                userInput = Console.ReadLine();
                Console.ResetColor();

                string[] productNamesId = userInput.Split(',');

                userInput = userInput.Trim();

                id = int.Parse(productNamesId[0]);
                product = productNamesId[1];

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    dic.Add(id, product);
                    return dic;
                }
                if (!ValidInput(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input!");
                    Console.ResetColor();
                    continue;
                }

                if (dic.ContainsKey(id))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The product list already contains the id {id}");
                    Console.ResetColor();
                }

                //else
                //{
                //    dic.Add(id, product);
                //}
            }
        }

        private static bool ValidInput(string userInput)
        {
            return Regex.IsMatch(userInput, @"^\d+,[a-z ]+$", RegexOptions.IgnoreCase);
        }

        private static void PrintProductDictionary(Dictionary<int, string> dic)
        {
            foreach (var item in dic)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Product ID = {id} and name = {product}");
                Console.ResetColor();
            }
        }
    }
}
