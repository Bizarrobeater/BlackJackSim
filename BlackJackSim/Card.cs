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
            string rank;
            char suit;

            switch (_rank)
            {
                case Rank.King:
                    rank = "K";
                    break;
                case Rank.Queen:
                    rank = "Q";
                    break;
                case Rank.Jack:
                    rank = "J";
                    break;
                case Rank.Ace:
                    rank = "A";
                    break;
                default:
                    rank = ((int)_rank).ToString();
                    break;
            }

            switch (_suit)
            {
                case Suit.Hearts:
                    suit = '\u2665';
                    break;
                case Suit.Diamonds:
                    suit = '\u2666';
                    break;
                case Suit.Clubs:
                    suit = '\u2663';
                    break;
                case Suit.Spades:
                    suit = '\u2660';
                    break;
                default:
                    suit = '1';
                    break;
            }
            return $"{rank} {suit}";
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
