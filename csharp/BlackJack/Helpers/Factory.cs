using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public static class Factory
    {
        public static IPlayer CreatePlayer()
        {
            return new Player();
        }

        public static IDealer CreateDealer()
        {
            return new Dealer();
        }

        public static IGame CreateGame()
        {
            return new Game();
        }

        public static IDeck CreateDeck()
        {
            return new Deck();
        }

        public static ICard CreateCard()
        {
            return new Card();
        }
    }
}
