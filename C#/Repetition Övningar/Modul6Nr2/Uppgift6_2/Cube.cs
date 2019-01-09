using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift6_2
{
    class Cube
    {
        //Constructor
        public Cube(int h, int w, int d)
        {
            Height = h;
            Width = w;
            Depth = d;
        }

        //Properties
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }

        public void WriteVolume()
        {
            double volume = Height * Width * Depth;
            Console.WriteLine($"The volume of the cube is {volume}");
        }

        public double CalculateVolume()
        {
            return Width * Height * Depth;
        }

        public double CalculateArea()
        {
            double area = (Height * Width) * 4 + (Height * Depth) * 2;
            return area;
        }

        public void ChangeColor()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
