using System;

namespace Modul8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The chocolate contains 24 pieces");
            decimal persons = AskHowMany();
            CalculatePieces(persons);
        }


        static decimal AskHowMany()
        {
            Console.Write("How many want to share? ");
            Console.ForegroundColor = ConsoleColor.Green;

            decimal persons = decimal.Parse(Console.ReadLine());

            Console.WriteLine();
            return persons;

        }

        static void CalculatePieces(decimal persons)
        {
            try
            {
            Console.ResetColor();
            decimal each = 24 / persons;
            Console.WriteLine($"Everyone gets {each} pieces");
            Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have to enter a number!");
                Console.ResetColor();
                Console.WriteLine();
            }
            catch (ArgumentException)
            {
                if (persons < 0)
                {
                    Console.WriteLine("You can't enter a negative number!");
                }

            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have to enter a number higher than 0!");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
