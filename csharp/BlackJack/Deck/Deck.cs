using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class Deck : IDeck
    {
        public Queue<Card> Cards { get; set; }
        public Deck()
        {

            newDeck();

        }

        public void newDeck()
        {
            Random random = new Random();


            List<Card> deck = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {

                for (int i = 1; i < 14; i++)
                {
                    deck.Add(new Card { Rank = i, Suit = suit });
                }
            }
            IOrderedEnumerable<Card> shuffleDeck = deck.OrderBy(i => random.Next());
            Cards = new Queue<Card>(shuffleDeck);
        }

    }
}
