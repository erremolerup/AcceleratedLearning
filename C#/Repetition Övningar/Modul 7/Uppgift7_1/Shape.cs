using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift7_1
{
    public abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public string Name { get; set; }

        public abstract double CalculateArea();

        public override string ToString()
        {
            return "I'm a shape";
        }
    }
}
