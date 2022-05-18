using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public static class PrintConsole
    {


        public static bool PlayAgain()
        {
            Console.WriteLine("Play again? y or n");

            var playAgainQ = Console.ReadLine();
 

            return playAgainQ == "y" ? true : false;

        }

        internal static void PrintHit(ICard card, IBasePlayer player)
        {
            if (player is IDealer)
                Console.WriteLine("***** Dealer Hit with {0}. Total is {1} *****", card, player.Total);
            else
                Console.WriteLine("Hit with {0}. Total is {1}", card, player.Total);
        }

        internal static void PlayerWon()
        {
            Console.WriteLine("You won!");
        }

        internal static void StandOrHit()
        {
            Console.WriteLine("Stand, Hit");

        }

        internal static void YouLost()
        {
            Console.WriteLine("You lost!");
        }
    }
}
