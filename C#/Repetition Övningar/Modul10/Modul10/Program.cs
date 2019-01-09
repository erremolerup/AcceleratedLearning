using System;
using System.Collections.Generic;

namespace Modul10
{
    class Program
    {
        static void Main(string[] args)
        {
            AskUserForInput();
        }

        public static void AskUserForInput()
        {
            var list = new List<string>();

            while (true)
            {
            Console.Write("Enter a name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    list.Sort();

                    //if (list.Count >= 2)
                    //{
                    //    list.RemoveAt(0);
                    //    list.RemoveAt(list.Count - 1);
                    //}
                    DisplayPeople(list);
                    return;
                }
                list.Add(input);
                Console.ResetColor();
            }
        }

        private static void DisplayPeople(List<string> list)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (var input in list)
            {
                Console.WriteLine($"Name: {input}");
            }
        }
    }
}
