using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CardGame2.Card;

namespace CardGame2
{
    public static class DeckCreator
    {
        public static Queue<Card> CreateCards()
        {
            Queue<Card> cards = new Queue<Card>();

            for (int i = 2; i <= 14; i++)
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    cards.Enqueue(new Card()
                    {
                        CardSuit = suit,
                        Value = i,

                    });
                }
            }
            return Shuffle(cards);
        }

        private static Queue<Card> Shuffle(Queue<Card> cards)
        {
            List<Card> transformedCards = cards.ToList();
            Random r = new Random(DateTime.Now.Millisecond);
            for (int n = transformedCards.Count - 1; n > 0; --n)
            {

            }
        }
    }
}
