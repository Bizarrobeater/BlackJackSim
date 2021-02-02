using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackSim
{
    public class Card
    {
        internal Rank _rank { get; init; }
        internal Suit _suit { get; init; }
        internal bool _isRevealed { get; set; }

        public Rank GetRank() => _rank;
        public Suit GetSuit() => _suit;
        public Color GetColor()
        {
            if (_suit == Suit.Spades ||
                _suit == Suit.Clubs)
                return Color.Black;
            else
                return Color.Red;
        }

        public bool IsRevealed() => _isRevealed;

        public Card(Rank rank, Suit suit)
        {
            _rank = rank;
            _suit = suit;
        }

        public override string ToString()
        {
            return $"{_rank} {_suit}";
        }

        public virtual void FlipCard()
        {
            _isRevealed = !_isRevealed;
        }
    }


    //TODO: BlackJack Value Rules
    
    //private int[] BlackJackCardValue()
    //{
    //    switch (_rank)
    //    {
    //        case Rank.King:
    //        case Rank.Queen:
    //        case Rank.Jack:
    //            return new int[] { 10 };
    //        case Rank.Ace:
    //            return new int[] { 1, 11 };
    //        default:
    //            return new int[] { (int)_rank };
    //    }
    //}
}
