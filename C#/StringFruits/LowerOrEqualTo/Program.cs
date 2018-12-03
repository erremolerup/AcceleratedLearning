using System;

namespace LowerOrEqualTo
{
    class Program
    {
        private static int number;
        private static int compare;

        static void Main(string[] args)
        {
            //Console.Write("Enter a number: ");
            //number = int.Parse(Console.ReadLine());
            //Console.Write("Enter another number to compare with:");
            //compare = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Green;

            //if (number < compare)
            //{
            //    Console.WriteL ine("Your first number is lower than your second number");
            //}
            //else if (number == compare)
            //{
            //    Console.WriteLine("Your first number is equal to your second number");
            //}
            //else
            //{
            //    Console.WriteLine("Your first number is higher than your second number");
            //}

            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.White;

            //Spel, generera random nummer och låta "spelaren" gissa
            //Random random = new Random();
            //int randomNumber = random.Next(1, 100);

            //Uppgift 3.7
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Enter another number to compare with:");
            compare = int.Parse(Console.ReadLine());

            //conditional operator within itself
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            var result = number == compare ? "Your first number equals your second number" : (number > compare ? "Your first number is bigger than your second number" : "Your second number is bigger than your first number");
            Console.WriteLine(result);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
    }
}
