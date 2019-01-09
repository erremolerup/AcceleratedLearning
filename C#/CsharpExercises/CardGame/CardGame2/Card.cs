using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame2
{
    public class Card
    {
        public string DisplayName { get; set; }
        public Suit CardSuit { get; set; }
        public int Value { get; set; }

        public enum Suit
        {
            Klöver,
            Ruter,
            Spader,
            Hjärter
        }
    }
}
