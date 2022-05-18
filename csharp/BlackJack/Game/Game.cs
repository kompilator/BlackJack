using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Game : IGame
    {
 

        public void Play()
        {

            IPlayer player = Factory.CreatePlayer();
            IDealer dealer = Factory.CreateDealer();
            IDeck deck = Factory.CreateDeck();
            GameLogic.Reset(dealer, player, deck);

            while (GameLogic.play)
            {
                if(GameLogic.roundnumber == 1)
                    dealer.Hit(deck, dealer);
                GameLogic.PlayerTurn(player, dealer, deck);
                

            }

        }


    }
}
