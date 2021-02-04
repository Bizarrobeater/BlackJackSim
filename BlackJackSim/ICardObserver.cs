using System.Collections.Generic;

namespace BlackJackSim
{
    interface ICardObserver
    {
        public List<Card> ObserveCards();
    }
}