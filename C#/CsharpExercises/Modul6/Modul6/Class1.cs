using System;
using System.Collections.Generic;
using System.Text;

namespace Modul5
{
    public class Car
    {
        public Car(string c, int w)
        {
            Color = c;
            Weight = w;
        }

        public Car()
        {
        }
        public int Weight { get; set; }
        public string Color { get; set; }
    
        //    public void SetColor(string xxx)
        //    {
        //        Color = xxx;
        //    }

        //    public string GetColor()
        //    {
        //        return Color;
        //    }

        //    public void SetWeight(int yyy)
        //    {
        //        Weight = yyy;
        //    }

        //    public int GetWeight()
        //    {
        //        return Weight;
        //    }
    }

}
