using System;
using System.Collections.Generic;


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
            PrintProducts(dic);
            Console.WriteLine();
        }

        private static Dictionary<int, string> CreateDictionary()
        {

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter product ID and name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                userInput = Console.ReadLine();
                Console.ResetColor();

                string[] productNamesId = userInput.Split(',');


                userInput = userInput.Trim();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    return dic;
                }

                id = int.Parse(productNamesId[0]);
                product = productNamesId[1];

                if (dic.ContainsKey(id))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The product list already contains the id {id}");
                    Console.ResetColor();
                }
                else
                {
                    dic.Add(id, product);
                }

            }
        }

        private static void PrintProducts(Dictionary<int, string> dic)
        {
            foreach (var item in dic)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Product id={id} and name={product}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
