namespace BlackJack
{
    public interface IBasePlayer
    {
        int Total { get; set; }

        ICard Hit(IDeck deck, IDealer dealer);
    }
}