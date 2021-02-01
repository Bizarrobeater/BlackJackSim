using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackSim
{
    public class BlackJackShoe : IShoe
    {
        internal List<Card> _cards;

        public BlackJackShoe()
        {
            _cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            if (card._isRevealed)
                card.FlipCard();
            _cards.Add(card);
        }

        public void AddDeck()
        {
            List<Card> tempList = DeckFactory.NewDeck();
            foreach (Card card in tempList)
            {
                AddCard(new BlackJackCard(card.GetRank()));
            }
        }

        public Card DrawCard()
        {
            Card returnCard = _cards[0];
            _cards.RemoveAt(0);
            return returnCard;
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            int n = _cards.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Card value = _cards[k];
                _cards[k] = _cards[n];
                _cards[n] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Card card in _cards)
            {
                sb.Append($"{card}\n");
            }
            return sb.ToString();
        }
    }
}
