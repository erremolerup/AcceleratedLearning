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

            mycube.ChangeColor();
            mycube.WriteVolume();
            supercube.WriteVolume();

            double volume = mycube.CalculateVolume();
            Console.WriteLine($"Volume: {volume}");

            double area = mycube.CalculateArea();
            Console.WriteLine($"Area: {area}");
        }
    }
}
