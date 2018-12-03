using System;

namespace Uppgift2_3
{
    //Användaren ska kunna mata in 3 frukter och programmet ska kunna svara med alla angivna frukter tre gånger i grönt
    class Program
    {
        static string fruit1;
        static string fruit2;
        static string fruit3;
        static string fruits = fruit1 + fruit2 + fruit3;

        static void Main(string[] args)
        {
            AskUserForFruit();
        }

        private static void AskUserForFruit()
        {
            Console.Write("Enter fruit 1: ");
            string fruit1 = Console.ReadLine();

            Console.Write("Enter fruit 2: ");
            string fruit2 = Console.ReadLine();

            Console.Write("Enter fruit 3: ");
            string fruit3 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            //Concatenation
            Console.WriteLine("You entered three fruits: " + fruit1 + ", "+ fruit2  + ", " + fruit3);
            //Using placeholders
            Console.WriteLine(string.Format("You entered three fruits: " + fruit1 + ", "+ fruit2 + ", " + fruit3));
            //Interpolation
            var fruits = $"You entered three fruits: {fruit1}, {fruit2}, {fruit3}";
            Console.WriteLine(fruits);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }
    }
}
