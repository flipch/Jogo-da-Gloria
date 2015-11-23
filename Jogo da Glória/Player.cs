namespace Jogo_da_Glória
{
    internal class Player
    {
        public Player(int playerId, int playerCurrentPos)
        {
            Id = playerId;
            CurrentPos = playerCurrentPos;
            DrinksCounter = 0;
            FirstTime = true;
        }

        internal bool FirstTime { get; set; }

        public int Id { get; set; }

        public int CurrentPos
        {
            get { return CurrentPos1; }
            set
            {
                if (value > 30)
                {
                    CurrentPos1 = 30 - (value - 30);
                }
                else if (value <= 0)
                {
                    CurrentPos1 = value*-1 + 0;
                }
                else
                    CurrentPos1 = value;
            }
        }

        public int DrinksCounter { get; set; }

        public int CurrentPos1 { get; set; }

        public override string ToString()
        {
            return $"Player : {Id} is at {CurrentPos}, and drank {DrinksCounter} time/s";
        }
    }
}