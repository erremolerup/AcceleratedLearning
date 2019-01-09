using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Player
    {
        public string Name { get; set; }
        public Queue<PlayingCard> Deck { get; set; }
    }
}
