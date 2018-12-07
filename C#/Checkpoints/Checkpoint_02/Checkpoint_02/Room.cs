using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint_02
{
    class Room
    {
        //PROPERTIES, rummets egenskaper
        public string Name { get; set; }
        public string Size { get; set; }
        //public int SizeUnit { get; set; }
        public int Number { get; set; }

        //KONSTRUKTORER
        public Room(string n, string s, int nr)
        {
            Name = n;
            Size = s;
            //SizeUnit = sU;
            Number = nr;
        }

        public Room()
        {
        }
    }
}


