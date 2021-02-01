using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackSim
{
    public abstract class Card
    {
        internal Rank _rank;
        internal Suit _suit;
        internal Color _color;
        internal bool _isRevealed;

        public virtual void FlipCard()
        {
            _isRevealed = !_isRevealed;
        }
    }

    public class BlackJackCard : Card, ICard
    {
        public BlackJackCard(Rank rank)
        {
            _rank = rank;
            _suit = Suit._;
            _color = Color._;
            _isRevealed = false;
        }

        public Card GetCard()
        {
            return this;
        }

        public int[] GetValue()
        {
            return BlackJackCardValue();
        }

        public bool IsRevealed()
        {
            return _isRevealed;
        }

        private int[] BlackJackCardValue()
        {
            switch (_rank)
            {
                case Rank.King:
                case Rank.Queen:
                case Rank.Jack:
                    return new int[] { 10 };
                case Rank.Ace:
                    return new int[] { 1, 11 };
                default:
                    return new int[] { (int)_rank };
            }
        }
    }
}
