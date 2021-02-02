using System.Collections.Generic;

namespace BlackJackSim
{
    class PlayerPosition : IPosition
    {
        int _currentBet;
        List<Card> _cards;
        bool _inUse;
        List<ICardObserver> _observers;


        public PlayerPosition()
        {
            _cards = new List<Card>();
            _inUse = false;
        }

        public void AddCard(Card card)
        {
            if (!card.IsRevealed())
                card.FlipCard();

            _cards.Add(card);
            ActivateObservers(card);
        }

        public List<Card> ReadCards()
        {
            return _cards;
        }

        public List<Card> RemoveCards()
        {
            List<Card> removedCards = new List<Card>(_cards);
            _cards.Clear();
            return removedCards;

        }

        private void ActivateObservers(Card card)
        {
            foreach (ICardObserver observer in _observers)
            {
                observer.ObserveNewCard(card);
            }
        }
    }
}