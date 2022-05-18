namespace BlackJack
{
    public interface IDealer : IBasePlayer
    {
        int LimitTotal { get; set; }
        ICard RobotHit(IDeck deck);
    }
}