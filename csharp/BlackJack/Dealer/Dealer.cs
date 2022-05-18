using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Dealer : BasePlayer, IDealer
    {

        public int LimitTotal { get; set; } = 17;

        public void RobotHit(IDeck deck)
        {
 
            while(Total <= LimitTotal && Total < 21)
            {
                Hit(deck, this);
 
            }

 
        }
    }
}
