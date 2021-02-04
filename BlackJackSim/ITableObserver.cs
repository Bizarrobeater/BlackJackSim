using System.Collections.Generic;

namespace BlackJackSim
{
    interface ITableObserver : ICardObserver
    {
        public List<Card> GetCardsOnPosition();

    }
}