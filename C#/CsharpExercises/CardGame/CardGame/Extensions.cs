using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public static class Extensions
    {
        public static void Enqueue(this Queue<PlayingCard> cards, Queue<PlayingCard> newCards)
        {
            foreach (var card in newCards)
            {
                cards.Enqueue(card);
            }
        }
    }
}
