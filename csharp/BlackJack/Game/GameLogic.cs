using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public static class GameLogic
    {
        internal static int roundnumber;

        public static bool play { get; set; } = true;

        public static void Reset(IDealer dealer, IBasePlayer player, IDeck deck)
        {
            player.Total = 0;
            dealer.Total = 0;
            roundnumber = 1;
            deck.newDeck();
        }


        public static void CheckForLoss(ICard card, IBasePlayer player, IDeck deck, IDealer dealer)
        {
            if (player.Total == 21)
            {
                PrintConsole.PrintHit(card, player);
                PrintConsole.PlayerWon();
                playAgain(dealer, player, deck);
                return;
            }
            else if (player.Total > 21)
            {
                PrintConsole.PrintHit(card, player);
                PrintConsole.YouLost();
                playAgain(dealer, player, deck);
                return;
            }
            PrintConsole.PrintHit(card, player);
            GameLogic.roundnumber++;
        }

        public static void CheckForWin(IPlayer player, IDealer dealer, IDeck deck)
        {
            var playerdiff = player.Total == 0 ? 0 : 21 - player.Total;
            var dealerdiff = 21 - dealer.Total;


            if (playerdiff < dealerdiff && playerdiff > -1)
            {
                Console.WriteLine("You won!");
            }
            else if (playerdiff > dealerdiff && dealerdiff > -1)
            {
                Console.WriteLine("Dealer won!");
            }
            else
            {
                Console.WriteLine("Tie!");
            }

            playAgain(dealer, player, deck);


        }

        private static void playAgain(IDealer dealer, IBasePlayer player, IDeck deck)
        {
            play = PrintConsole.PlayAgain();

            if (play)
                Reset(dealer, player, deck);
        }

        internal static void PlayerTurn(IPlayer player, IDealer dealer, IDeck deck)
        {
            PrintConsole.StandOrHit();

            string standOrHit = Console.ReadLine(); 
            ICard card = Factory.CreateCard();

            if (standOrHit == "Hit")
            {
                player.Hit(deck, dealer);
                

            }
            else if(standOrHit == "Stand")
            {
                dealer.RobotHit(deck);
                CheckForWin(player, dealer, deck);
            }


        }
    }
}
