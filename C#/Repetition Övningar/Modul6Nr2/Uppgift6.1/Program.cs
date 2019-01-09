using System;

namespace Uppgift6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCircles();
        }

        private static void CreateCircles()
        {
            Circle bob = new Circle("Bob", 8);
            Circle lisa = new Circle("Lisa", 12);

            bob.SayHello();
            bob.WriteArea();

        }
    }
}
