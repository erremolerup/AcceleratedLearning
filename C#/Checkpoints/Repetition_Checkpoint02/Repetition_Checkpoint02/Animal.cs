using System;
using System.Collections.Generic;
using System.Text;

namespace Repetition_Checkpoint02
{
    public class Animal
    {
        //Properties - prop
        //Ett djurs egenskaper
        public int Age { get; set; }
        public string Name { get; set; }

        //Konstruktorer - ctor
        public Animal(int x, string n)
        {
            Name = n;
            Age = x;
        }
        //Sätta defaultvärde på ben
        public Animal(string n)
        {
            Name = n;
            Age = 4;
        }
        public Animal()
        {

        }
    }
}
