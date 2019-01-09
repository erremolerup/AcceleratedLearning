using System;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {

            //Test1();
            //Test2();
            //Test3();
            Test4();
            Console.ReadKey();
        }

        private static void Test4()
        {
            var deck = new PlayingCardDeck();
            deck.AddSomeCards();

            int nr = deck.GetNumberOfCards();
            Console.WriteLine($"Antal kort i kortleken är {nr}");
        }

        private static void Test3()
        {
            var deck = new PlayingCardDeck();
            deck.AddSomeCards();

            deck.PrintNumberOfCards();

        }

        private static void Test2()
        {
            var card = new PlayingCard(CardValue.Ess, CardSuit.Spader);
            var card2 = new PlayingCard(CardValue.Fyra, CardSuit.Klöver);

            // PrintCard(card);

            card.PrintCard();
            card2.PrintCard();
            card.PrintCard();

        }

        private static void PrintCard(PlayingCard card)
        {
            Console.WriteLine($"Ditt kort är: {card.Suit} {card.Value}");
        }

        private static void Test1()
        {
            var card = new PlayingCard(CardValue.Dam, CardSuit.Hjärter);

            if (card.Suit == CardSuit.Hjärter)
                Console.WriteLine("Det är hjärter!");
            else
                Console.WriteLine("Det är inte hjärter...");


            if (card.Value == CardValue.Dam)
            {
                Console.WriteLine("Det är en dam");
            }
            else
            {
                Console.WriteLine("Det är inte en dam");
            }

            Console.WriteLine($"Kortets valör är {card.Value}");
        }
    }
}
