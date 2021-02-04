using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackSim
{
    public enum Rank : int
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14,
        _ = 15
    }

    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades,
        _
    }

    public enum Color
    {
        Black,
        Red,
        _

    }
}
