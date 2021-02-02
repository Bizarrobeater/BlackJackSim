using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackSim
{

    // Deckfactory creates a standard deck of 52 playing cards
    public static class DeckFactory
    {
        public static List<Card> NewDeck()
        {
            List<Card> newDeck = new List<Card>();

            // First Card
            Card newCard = new Card(Rank.Two, Suit.Hearts);
            newDeck.Add(newCard);

            while (succCard(newCard, out newCard))
            {
                newDeck.Add(newCard);
            }
            return newDeck;
        }

        // returns the next suit in the enum
        private static Suit NextSuit(Suit suit)
        {
            Suit nextSuit = suit + 1;
            return nextSuit;
        }

        // returns the next rank in the enum
        private static Rank NextRank(Rank rank)
        {
            Rank nextRank = rank + 1;
            return nextRank;
        }

        // returns a bool based on if the next card exist
        // only a case of of rank = _ and suit = _ is false
        private static bool succCard(Card card, out Card newCard)
        {
            Rank newRank = NextRank(card.GetRank());

            if (newRank != Rank._)
                newCard = new Card(newRank, card.GetSuit());

            else
            {
                Suit newSuit = NextSuit(card.GetSuit());
                if (newSuit != Suit._)
                    newCard = new Card(Rank.Two, newSuit);
                else
                {
                    newCard = new Card(Rank._, Suit._);
                    return false;
                }
            }
            return true;
        }

    }
}
