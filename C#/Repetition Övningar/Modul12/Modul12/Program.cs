using System;
using System.Collections.Generic;

namespace Modul12
{
    public class Program
    {
        public static void Main()
        {
            string[] rockstarsArray = { "Slash", "Steven Tyler", "Axl Rose" };
            List<string> rockstarsList = new List<string> { "Slash", "Steven Tyler", "Axl Rose" };

            DisplayArrayOfRockstars("My favorite rockstars: (array)", rockstarsArray);
            DisplayListOfRockstars("My favorite rockstars: (list)", rockstarsList);

            DisplayRockstars("My favorite rockstars: (ienumerable)", rockstarsArray);
            DisplayRockstars("My favorite rockstars: (ienumerable)", rockstarsList);
        }

        private static void DisplayRockstars(string header, IEnumerable<string> rockstars)
        {
            WriteWhite(header);

            foreach (string rockstar in rockstars)
            {
                WriteDark($" * {rockstar}");
            }
            Console.WriteLine();
        }

        private static void DisplayListOfRockstars(string header, List<string> rockstars)
        {
            WriteWhite(header);

            foreach (string rockstar in rockstars)
            {
                WriteDark($" * {rockstar}");
            }
            Console.WriteLine();
        }
        private static void DisplayArrayOfRockstars(string header, string[] rockstars)
        {
            WriteWhite(header);

            foreach (string rockstar in rockstars)
            {
                WriteDark($" * {rockstar}");
            }
            Console.WriteLine();
        }

        public static void WriteDark(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(message);
        }

        public static void WriteWhite(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }
    }
}
