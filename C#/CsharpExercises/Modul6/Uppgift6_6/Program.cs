using System;

namespace Uppgift6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //DrawSquare(4, 20);
            //Console.WriteLine();
            //DrawSquare(8, 15);
            //Console.WriteLine();
            //DrawSquare(10, 10);
            //Console.WriteLine();

            MultiplicationTable(3);
        }

        private static void MultiplicationTable(int v)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Multiplicationtable for 1");
                Console.WriteLine();
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
                Console.WriteLine();
            }
        }

        //private static void DrawSquare(int x, int y)
        //{
        //    for (int i = 0; i < x; i++)
        //    {
        //    Console.Write("".PadLeft(y));
        //        for (int j = 0; j < x; j++)
        //        {
        //            Console.Write("o");
        //        }
        //        Console.WriteLine("o");
        //    }
        //}
    }
}
