using System;
using System.Collections.Generic;

namespace Uppgift7_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConsoleHelper ch = new ConsoleHelper();

            ch.InitConsole();

            new InheritanceLab().Run();

            ch.EndProgram();
            //AskForUserInput();
            //PrintShape();
        }

        //private static void AskForUserInput()
        //{
        //    string input;
        //    List<Shape> shapes = new List<Shape>();

        //    do
        //    {
        //        Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or (D)one: ");
        //        input = Console.ReadLine();

        //        if (input == "T")
        //        {
        //            var x = new Triangle();
        //            shapes.Add(x);
        //            Console.Write("Enter height of triangle: ");
        //            x.Height = int.Parse(Console.ReadLine());
        //            Console.Write("Enter width of triangle: ");
        //            x.Width = int.Parse(Console.ReadLine());
        //        }
        //        else if (input == "R")
        //        {
        //            var x = new Rectangle();
        //            shapes.Add(x);
        //            Console.Write("Enter sides of rectangle: ");
        //        }
        //        else if (input == "C")
        //        {
        //            var x = new Circle();
        //            shapes.Add(x);
        //            Console.Write("Enter radius of circle: ");
        //        }
        //    } while (input != "D");
        //}

        //private static void PrintShape()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
