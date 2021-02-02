namespace BlackJackSim
{
    class Player
    {
        int _money { get; set; }
        ICardObserver _cardObserver;

        public Player(int startMoney)
        {
            _money = startMoney;
        }

        public bool CanPlaceBet(int amount)
        {
            if (_money - amount < 0)
                return false;
            return true;
        }

        public void PlaceBet(int amount)
        {
            _money -= amount;
        }

        public void AddMoney(int amount)
        {
            _money += amount;
        }
    }
}