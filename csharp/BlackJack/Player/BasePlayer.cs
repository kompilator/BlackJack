using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public abstract class BasePlayer : IBasePlayer
    {

        public int Total { get; set; }
        public BasePlayer()
        {

        }

        public ICard Hit(IDeck deck, IDealer dealer)
        {
            var card = deck.Cards.Dequeue();

            if (card.Rank == 1)
            {
                var leftOver = Total == 0 ? 21 : 21 - Total;
                if (leftOver >= 10)
                    Total += 11;

                else
                    Total += 1;
                GameLogic.CheckForLoss(card, this, deck, dealer);
                return card;
            }
            else
            {
                Total += Math.Min(card.Rank, 10);
                GameLogic.CheckForLoss(card, this, deck, dealer);
                return card;
            }
        }
 


    }
}
