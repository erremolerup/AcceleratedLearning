using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{
    public class PlayingCardDeck
    {
        public Queue<PlayingCard> Deck { get; set; }

        List<PlayingCard> cards = new List<PlayingCard>();
        public void AddSomeCards()
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    var card = new PlayingCard(value, suit, faceDown);
                    cards.Add(card);
                }
            }
            //var card = new PlayingCard(CardValue.Kung, CardSuit.Klöver);
            //cards.Add(card);

            //var card2 = new PlayingCard(CardValue.Tio, CardSuit.Ruter);
            //cards.Add(card2);

            //var card3 = new PlayingCard(CardValue.Sju, CardSuit.Hjärter);
            //cards.Add(card3);
        }

        public int GetNumberOfCards()
        {
            return cards.Count;
        }

        public void PrintNumberOfCards()
        {
            Console.WriteLine($"Det är {cards.Count} kort i kortleken");
        }
    }
}
