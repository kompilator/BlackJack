namespace BlackJack
{
    public class Card : ICard
    {

        public Suit Suit { get; set; }
        public int Rank { get; set; }

        public override string ToString()
        {
            string rankToString;

            switch (Rank)
            {
                case 1:
                    rankToString = "A";
                    break;
                case 11:
                    rankToString = "J";
                    break;
                case 12:
                    rankToString = "Q";
                    break;

                case 13:
                    rankToString = "K";
                    break;


                default:
                    rankToString = $"{Rank}";
                    break;
            }
            return $"{Suit} {rankToString}";
        }
    }
}
