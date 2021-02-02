using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackSim
{
    interface IPosition
    {
        public List<Card> ReadCards();
        public void AddCard(Card card);
        public List<Card> RemoveCards();
    }
}
