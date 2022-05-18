namespace BlackJack
{
    public interface IDealer : IBasePlayer
    {
        int LimitTotal { get; set; }
        void RobotHit(IDeck deck);
    }
}