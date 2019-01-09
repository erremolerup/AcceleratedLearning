using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift7_1
{
    public class InheritanceLab
    {
        ConsoleHelper ch = new Console();

        public void Run()
        {
            List<Shape> shapeList = AskForListOfShapes();

            PrintAllShapes(shapeList);
            ReportAreaOfShapes(shapeList);
        }

        private List<Shape> AskForListOfShapes()
        {
            bool oneMore = true;
            List<Shape> allShapes = new List<Shape>();

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Select(T)riangle, (R)ectangle, (C)ircle or(D)one: ");
                Console.ForegroundColor = ConsoleColor.Green;

                char answer = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (answer.ToString().ToLower())
                {
                    case "t":
                        Triangle triangle = AskForTriangle();
                        allShapes.Add(triangle);
                        break;

                    case "r":
                        Rectangle rectangle = AskForRectangle();
                        allShapes.Add(rectangle);
                        break;

                    case "c":
                        Circle circle = AskForCircle();
                        allShapes.Add(circle);
                        break;

                    case "d":
                        oneMore = false;
                        break;
                }
            } while (oneMore);
        }

        private Circle AskForCircle()
        {
            double radius = ch.AskForNumber("Enter radius of a circle: ");
            return new Circle(radius);
        }

        private Rectangle AskForRectangle()
        {
            throw new NotImplementedException();
        }

        private Triangle AskForTriangle()
        {
            throw new NotImplementedException();
        }
    }
}
