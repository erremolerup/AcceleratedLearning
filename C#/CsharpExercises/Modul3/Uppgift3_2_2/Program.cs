using System;

namespace While
{
    class Program
    {
        static string name;
        static int times;
        static string repeat;

        static void Main(string[] args)
        {
            AskForUserName();
        }

        private static void AskForUserName()
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            if (name.Length < 2)
            {
                Console.WriteLine("The name you put in is too short. \nEnter another name:");
                name = Console.ReadLine();
            }

            Console.Write("Times to repeat: ");
            times = int.Parse(Console.ReadLine());

            //if (times < 1)
            //{
            //    Console.WriteLine("The number is too small. ");
            //}
            //if (times > 10)
            //{
            //    Console.WriteLine("Number is too big");
            //}

            Console.WriteLine();

            int n = 0;
            ////while (n < times)
            ////{
            ////    Console.WriteLine("Your name is " + name);
            ////    n++;
            ////}

            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Your name is " + name);
            }

            //while (true)
            //{
            //    Console.WriteLine("Your name is " + name);
            //    n++;

            //    if ((n + 1) > times)
            //        break; //hoppar ut 

            //}

            Console.WriteLine();
            // För extrauppgiften, nästla in en for-loop i en annan där ena är write och den andra writeLine, 

        }
    }
}
