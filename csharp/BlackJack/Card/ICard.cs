namespace BlackJack
{
    public interface ICard

    {
        Suit Suit { get; set; }
        int Rank { get; set; }

        string ToString();
    }
}