using System;

namespace Uppgift6_1
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
            var lisa = new Circle("Lisa", 30);
            var input = new Circle();
            var ali = new Circle("Ali");

            //bob.SayHello();
            //lisa.SayHello();
            //input.SayHello();
            //ali.SayHello();
            //Console.WriteLine();

            //bob.WriteArea();
            //lisa.WriteArea();
            //input.WriteArea();
            //ali.WriteArea();
            //Console.WriteLine();

        }
    }
    class Circle
    {
        //CONSTRUCTOR
        public Circle(string n, int r)
        {
            Name = n;
            Radius = r;
        }
        public Circle()
        {
            Name = "Unknown";
            Radius = 5;
        }
        public Circle(string n)
        {
            Name = n;
            Radius = 5;
        }

        //PROPERTIES
        public string Name { get; set; }
        public int Radius { get; set; }

        //METHODS
        public void SayHello()
        {
            Console.WriteLine($"I'm a circle with the name {Name}");
        }
        
        public void WriteArea()
        {
            double pi = Math.PI;
            double area = Radius * Radius * pi;

            Console.WriteLine($"My name is {Name}. I have the radius of {Radius} and area of {area}");

        }
    }
}
