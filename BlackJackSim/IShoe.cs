using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackSim
{
    public interface IShoe
    {
        public void AddDeck();
        public void AddCard(Card card);
        public Card DrawCard();
        public void Shuffle();
    }
}
