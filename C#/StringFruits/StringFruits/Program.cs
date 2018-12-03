using System;

namespace StringFruits
{
    class Program
    {
        static string fruit1;
        static string fruit2;
        static string fruit3;

        static void Main(string[] args)
        {
            //AskForFruits();
        }

        static void AskForFruits()
        {
            Console.Write("Enter fruit 1: ");
            String fruit1 = Console.ReadLine();

            Console.Write("Enter fruit 2: ");
            String fruit2 = Console.ReadLine();

            Console.Write("Enter fruit 3: ");
            String fruit3 = Console.ReadLine();

            Console.WriteLine();
           
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("You entered three fruits: " + fruit1 + ", " + fruit2 + ", " + fruit3); //Concatenation

            String fruits = String.Format("You entered three fruits: {0}, {1}, {2}", fruit1, fruit2, fruit3); //Using placeholders
            Console.WriteLine(fruits);

            Console.WriteLine($"You entered three fruits: {fruit1}, {fruit2}, {fruit3}"); //Interpolation

            Console.WriteLine();
        }
    }
}
