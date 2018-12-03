using System;

namespace Uppgift6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCubes();
        }

        private static void CreateCubes()
        {
            Cube mycube = new Cube(2, 3, 4);
            Cube supercube = new Cube(100, 200, 300);

            double volume = mycube.CalculateVolume();
            Console.WriteLine($"Volume: {volume}");

            double area = mycube.CalculateArea();
            Console.WriteLine($"Area: {area}");


            mycube.WriteVolume();
            supercube.WriteVolume();
            mycube.CalculateVolume();
            double superVolume = supercube.CalculateVolume();
            Console.WriteLine($"Volume: {superVolume}");
        }

            
    }  
    class Cube
    {
        //CONSTRUCTOR
        public Cube(int h, int w, int d)
        {
            Height = h;
            Width = w;
            Depth = d;
        } 
        

        //PROPERTIES
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
       

        //METHODS
        public void WriteVolume()
        {
            Console.WriteLine($"The volume of the cube is {Height * Width * Depth}");
        }
        public double CalculateVolume()
        {
            //double volume = Height * Width * Depth;
            //return volume;

            return Width * Height * Depth;
        }

        public double CalculateArea()
        {
            double area = (Height * Width) * 4 + (Height * Depth) * 2;
            return area;
        }

    }
}
