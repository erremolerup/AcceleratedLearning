using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CardGame
{
    public enum CardSuit
    {
        Spader = 1,
        Hjärter,
        Ruter,
        Klöver
    }

    public enum CardValue
    {
        Ess = 1,
        Två = 2, Tre = 3, Fyra = 4, Fem = 5, Sex = 6, Sju = 7, Åtta = 8, Nio = 9, Tio = 10,
        Knekt = 11,
        Dam = 12,
        Kung = 13
    }

    // Class, ett substantiv
    public class PlayingCard
    {
        //PROPERTIES (Minnet)
        public string DisplayName { get; set; }
        public CardSuit Suit { get; }
        public CardValue Value { get;}

        public bool FaceDown { get; set; }

        //KONSTRUKTORER (Hur man får skapa ett nytt kort)
        public PlayingCard(CardValue value, CardSuit suit, bool faceDown)
        {
            Value = value;
            Suit = suit;
            FaceDown = faceDown;
        }

        public void Flip()
        {
            FaceDown = !FaceDown;
        }
        
        //METODER (Riva sönder kortet, verb)
        public void PrintCard()
        {
            Console.WriteLine($"Ditt kort är: {Suit} {Value}");
        }
    }
}
