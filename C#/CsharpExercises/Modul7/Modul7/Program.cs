using System;
using System.Collections.Generic;

namespace Modul7
{
    class Program
    {
        static void Main(string[] args)
        {
            AskUSerForInput();
            PrintShape();


            var x1 = new Shapee();


            //List <Triangle> triangles = new List<Triangle>

        }

        private static void AskUSerForInput()
        {
            string input;

            List<Shapee> shapes = new List<Shapee>();
             
            //List<Triangle> triangles = new List<Triangle>();
            //List<Circle> circles = new List<Circle>();
            //List<Rectangle> rectangles = new List<Rectangle>();
            //while loop 

            do
            {
            Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or (D)one: ");
            input = Console.ReadLine();

                if (input == "T")
                {
                    var x = new Triangle();
                    shapes.Add(x);
                    Console.Write("Enter height of triangle: ");
                    x.Height = int.Parse(Console.ReadLine());
                    Console.Write("Enter width of triangle: ");
                    x.Width = int.Parse(Console.ReadLine());
                }
                else if (input == "R")
                {
                    var x = new Rectangle(); 
                    shapes.Add(x);
                }
                else if (input == "C")
                {
                    var x = new Circle();
                    shapes.Add(x);
                }

            } while (input != "D");
        }

        private static void PrintShape()
        {
        }
    }
}
