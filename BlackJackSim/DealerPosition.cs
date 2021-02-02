using System.Collections.Generic;

namespace BlackJackSim
{
    class DealerPosition : IPosition
    {
        List<Card> _cards;


        public DealerPosition()
        {
            _cards = new List<Card>();
        }
        public void AddCard(Card card)
        {
            throw new System.NotImplementedException();
        }

        public List<Card> ReadCards()
        {
            return _cards;
        }

        public List<Card> RemoveCards()
        {
            throw new System.NotImplementedException();
        }
    }
}