using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift7_1
{
    public class Circle : Shape
    {
        double _radius;

        public Circle(double radius)
        {
            _radius = radius;

            Name = "Circle";
        }

        public override string ToString()
        {
            return $"I'm a circle with the radius={_radius}";
        }

        public override double CalculateArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
