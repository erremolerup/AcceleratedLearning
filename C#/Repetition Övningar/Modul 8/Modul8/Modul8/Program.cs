using System;

namespace Modul8
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeText();
            decimal input = AskUserForHowMany();
            /*decimal pieces = */CalculatePieces(input);
            //PrintPieces(pieces);
        }

        public static void PrintWelcomeText()
        {
            Console.WriteLine("The chocolate contains 24 pieces");
        }

        public static decimal AskUserForHowMany()
        {
            Console.Write("How many want to share? ");
            Console.ForegroundColor = ConsoleColor.Green;

            decimal x = decimal.Parse(Console.ReadLine());

            Console.ResetColor();
            return x;
        }

        static void CalculatePieces(decimal input)
        {
            try
            {
                decimal x = 24 / input;
                Console.WriteLine($"Everyone gets {input} pieces");
                Console.WriteLine();
            }
            catch (FormatException)
            {
                if (input == null)
                {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have to enter a number!");
                Console.ResetColor();
                Console.WriteLine();
                }
                
            }
            catch (ArgumentException)
            {
                if (input < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can't enter a negative number!");
                    Console.ResetColor();
                }
            }
            catch (Exception)
            {
                if (input == 0)
                {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have to enter a number higher than 0!");
                Console.ResetColor();
                Console.WriteLine();
                }
            }

        }
        
        private static void PrintPieces(decimal pieces)
        {
            Console.WriteLine($"Everyone get {pieces} pieces");
        }
    }
}
