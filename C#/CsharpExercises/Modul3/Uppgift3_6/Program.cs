using System;

namespace Uppgift3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            AskUserForANumber();
            
        }

        public static void AskUserForANumber()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //if (number < 20)
            //{
            //    Console.WriteLine("Lower than 20");
            //}
            //else if (number > 20)
            //{
            //    Console.WriteLine("Higher than 20");
            //}
            //else
            //{
            //    Console.WriteLine("Equal to 20");
            //}
            //Console.WriteLine();

            string conditionalnumber = number == 20 ? "lika med 20" : number < 20 ? "mindre än 20" : "mer än 20";
            Console.WriteLine(conditionalnumber);
            Console.WriteLine();

        }
        


        
    }
}
