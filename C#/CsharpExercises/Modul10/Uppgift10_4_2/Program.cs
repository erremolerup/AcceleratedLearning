using System;
using System.Collections.Generic;

namespace Uppgift10_4_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            NamesWithListManipulate();
        }

        private static void NamesWithListManipulate()
        {
            var list = new List<string>();

            while (true)
            {
                Console.Write("Enter a name: ");
                string name = Console.ReadLine();
                if (name.ToLower() == "quit")
                {
                    list.Sort();

                    if (list.Count >= 2)
                    {
                        list.RemoveAt(0);
                        list.RemoveAt(list.Count - 1);
                    }
                    DisplayPeople(list);
                    return;
                }
                list.Add(name);
            }
        }

        private static void DisplayPeople(List<string> list)
        {
            foreach (var name in list)
            {
                Console.WriteLine($"Name: {name}");
            }
        }
    }
}
