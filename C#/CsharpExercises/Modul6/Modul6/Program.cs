using System;

namespace Modul5
{
    class Program
    {


        static void Main(string[] args)
        {
            var c1 = new Car("blå", 1330);
            //c1.SetColor("blå");
            //c1.SetWeight(1330);

            Car c2 = new Car("röd", 500);
            //c2.SetColor("röd"); 
            //c2.SetWeight(500);

            Car c3 = new Car();
            //c3.SetColor("vit");
            //c3.SetWeight(1000);

            Console.WriteLine($"Bil 1 är " + c1.Color + " och väger " + c1.Weight + " kg");
            Console.WriteLine($"Bil 2 är " + c2.Color + " och väger " + c2.Weight + " kg");
            Console.WriteLine($"Bil 3 är " + c3.Color + " och väger " + c3.Weight + " kg");

        }
    }
    

        //**********************************************************************************************************************************

            //var yyy = c1.GetColor();
            //var zzz = c2.GetColor();
            //var qqq = c3.GetColor();

            //Console.WriteLine("Färgen på bilen 'c1' är " + yyy);
            //Console.WriteLine("Färgen på bilen 'c2' är " + zzz);
            //Console.WriteLine("Färgen på bilen 'c3' är " + qqq);

        //    static void Main(string[] args)
        //    {
        //        Car car1 = new Car(); //Kan lika gärna skriva var istället för Car
        //        Car car2 = new Car();
        //        car1.SetColor("blå");
        //    }

        //}

        //class Car
        //{
        //    int Weight { get; set; } //bra att hålla så många variabler dolda som möjligt, ej beroende av varandra.
        //    string Color { get; set; }

        //    public void SetColor(string xxx)
        //    {
        //        Color = xxx;
        //    }

        //    public string GetColor()
        //    {
        //        return Color;
        //    }
        //}
    }


