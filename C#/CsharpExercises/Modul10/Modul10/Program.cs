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
            //var list = new List<string>();
            List<string> namesInput = new List<string>();

            while (true)
            {
                Console.Write("Enter a name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string name = Console.ReadLine();
                Console.ResetColor();

                if (name.ToLower() == "quit")
                {
                    namesInput.Sort();

                    if (namesInput.Count >= 2)
                    {
                        namesInput.RemoveAt(0);
                        namesInput.RemoveAt(namesInput.Count - 1);
                    }
                    DisplayPeople(namesInput);
                    return;

                }
                namesInput.Add(name);
            }
        }

        private static void DisplayPeople(List<string> namesInput)
        {
            foreach (var name in namesInput)
            {
                Console.WriteLine($"Name: {name}");
            }
        }

    }
}
