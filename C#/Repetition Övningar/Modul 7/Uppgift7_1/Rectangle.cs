using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift7_1
{
    public class Rectangle : Shape
    {
        double _height;
        double _width;

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;

            Name = "Rectangle";
        }

        public override double CalculateArea()
        {
            return _width * _height;
        }

        public override string ToString()
        {
            return $"I'm a rectangele with the height={_height} and width={_width}";
        }
    }
}