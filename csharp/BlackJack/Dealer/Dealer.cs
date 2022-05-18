using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Dealer : BasePlayer, IDealer
    {

        public int LimitTotal { get; set; } = 17;

        public ICard RobotHit(IDeck deck)
        {
            ICard card = null;
            while(Total <= LimitTotal && Total < 21)
            {
                card = Hit(deck, this);
 
            }

            return card;
        }
    }
}
