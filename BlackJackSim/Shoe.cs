using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackSim
{
    public class CardShoe
    {
        internal List<Card> _cards;

        public CardShoe()
        {
            _cards = new List<Card>();
        }

        // Initialised the shoe with a given amount of decks, then shuffles the shoe
        public void InitialiseShoe(int amountDecks = 1)
        {
            for (int i = 0; i < amountDecks; i++)
            {
                _cards.AddRange(DeckCreator.NewDeck());
            }
            Shuffle();
        }

        // Add a single card to the shoe, if the card is revealed, flips it.
        public void AddCard(Card card)
        {
            if (card._isRevealed)
                card.FlipCard();
            _cards.Add(card);
        }

        // Add a list of cards to the shoe and then shuffles
        public void AddDeck(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                AddCard(card);
            }
            Shuffle();
        }


        // if there are still cards in the shoe, draws one.
        // returns generic card if nothing is available
        public bool DrawCardIfPossible(out Card returnCard)
        {
            if (_cards.Count == 0)
            {
                returnCard = new Card(Rank._, Suit._);
                return false;
            }
            
            returnCard = _cards[0];
            _cards.RemoveAt(0);
            return true;
        }


        public void Shuffle()
        {
            Random rnd = new Random();
            int n = _cards.Count;

            // n = current position a randomly chosen card will be placed at
            // k = position of a randomly chosen card
            
            // loop starts with taking a random card and placing it at the end position
            // card currently at the end position will be placed where the random card came from

            // next loop is a new random card, and the position it is placed at is the end - 1 position
            // this goes on until all cards have been randomly place

            // this also means that when a card is randomly chosen and placed, it cannot be chosen again.
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Card card = _cards[k];
                _cards[k] = _cards[n];
                _cards[n] = card;
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
