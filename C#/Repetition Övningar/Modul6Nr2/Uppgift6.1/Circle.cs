using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift6._1
{
    class Circle
    {
        //Constructors
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

        //Properties
        public string Name { get; set; }
        public int Radius { get; set; }
        
        //Methods
        public void SayHello()
        {
            Console.WriteLine($"I'm a circle with the name {Name}!");
        }
        
        public void WriteArea()
        {
            double pi = Math.PI;
            double area = Radius * Radius * pi;

            Console.WriteLine($"My name is {Name}. I have a radius of {Radius} and area of {area}.");
        }

    }
}
