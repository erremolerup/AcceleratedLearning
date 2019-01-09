using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift7_1
{
    public class Triangle : Shape
    {
        double _baselength;
        double _height;
    
        public Triangle(double baselength, double height)
        {
            _baselength = baselength;
            _height = height;

            Name = "Triangle";
        }

        public override string ToString()
        {
            return $"I'm a triangle with baselength={_baselength} and height={_height}";
        }

        public override double CalculateArea()
        {
            return _baselength * _height / 2;
        }
    }
}
