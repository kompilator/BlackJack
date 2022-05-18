using System.Collections.Generic;

namespace BlackJack
{
    public interface IDeck
    {
        Queue<ICard> Cards { get; set; }

        void newDeck();
    }
}