using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class Deck : IDeck
    {
        public Queue<ICard> Cards { get; set; }
        public Deck()
        {

            newDeck();

        }

        public void newDeck()
        {
            Random random = new Random();


            List<ICard> deck = new List<ICard>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {

                for (int i = 1; i < 14; i++)
                {
                    ICard card = Factory.CreateCard();
                    card.Rank = i;
                    card.Suit = suit;
                    deck.Add(card);
                }
            }
            IOrderedEnumerable<ICard> shuffleDeck = deck.OrderBy(i => random.Next());
            Cards = new Queue<ICard>(shuffleDeck);
        }

    }
}
