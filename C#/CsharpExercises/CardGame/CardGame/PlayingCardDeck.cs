using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{
    public class PlayingCardDeck
    {
        public Queue<PlayingCard> Deck { get; set; }

        public PlayingCardDeck(bool backSideUp)
        {
            Deck = new Queue<PlayingCard>();

            foreach (var card in GenerateDeck(backSideUp))
            {
                Deck.Enqueue(card);
            }
        }

        public PlayingCard DrawTopCard()
        {
            return Deck.Dequeue();
        }

        public void PlaceCardAtBottom(PlayingCard card)
        {
            Deck.Enqueue(card);
        }

        public void ShuffleDeck()
        {
            List<PlayingCard> DeckAsList = this.Deck.ToList();
            this.Deck = new Queue<PlayingCard>();

            Random rnd = new Random();

            while (DeckAsList.Count > 0)
            {
                int cardIndex = rnd.Next(0, DeckAsList.Count);
                Deck.Enqueue(DeckAsList[cardIndex]);
                DeckAsList.RemoveAt(cardIndex);
            }
        }
        public static IEnumerable<PlayingCard> GenerateDeck(bool backSideUp)
        {
            foreach (var suit in GenerateSuit())
                foreach (var value in GenerateValue())
                    yield return new PlayingCard(suit, value, backSideUp);
        }

        private static IEnumerable<CardValue> GenerateValue()
        {
            foreach (var value in Enum.GetValues(typeof(CardValue)))
                yield return value;
        }

        private static IEnumerable<CardSuit> GenerateSuit()
        {
            foreach (var suit in Enum.GetValues(typeof(CardSuit)))
                yield return suit;
        }

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
