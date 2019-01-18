using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class PlayingCardGame
    {
        public PlayingCardDeck Deck { get; set; }
        public PlayingCard PlayersCard { get; set; }
        public PlayingCard TableCard { get; set; }
        public Player Player { get; set; }

        public HigherOrLower()
        {
            SetUpNewDeck();
        }

        private void SetUpNewDeck()
        {
            Deck = new PlayingCardDeck(true);
            Deck.ShuffleDeck();
        }
    }
}
