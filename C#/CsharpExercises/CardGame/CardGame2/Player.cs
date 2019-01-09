using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame2
{
    public class Player
    {
        public string Name { get; set; }
        public Queue<Card> Deck { get; set; }
    }
}
