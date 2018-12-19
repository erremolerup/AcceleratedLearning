using System;

namespace OneToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //SumNumbers();
            int number1 = AskForNumber();
            int number2 = AskForNumber();
            int sum = number1 + number2;
            DisplaySum(sum);
        }

        private static int AskForNumber()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        private static void DisplaySum(int sum)
        {
            Console.WriteLine($"Summan av tal ett och två är: {sum}");
        } 

        //private static void SumNumbers()
        //{
        //    Console.Write("Enter a number: ");
        //    int number1 = int.Parse(Console.ReadLine());
        //    Console.Write("Enter another number: ");
        //    int number2 = int.Parse(Console.ReadLine());

        //    Console.WriteLine($"The sum of the two numbers you entered is: {number1} + {number2} = {number1 + number2}");

        //}
    }
}
