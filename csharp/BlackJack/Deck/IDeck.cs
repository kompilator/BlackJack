using System.Collections.Generic;

namespace BlackJack
{
    public interface IDeck
    {
        Queue<Card> Cards { get; set; }

        void newDeck();
    }
}