using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackSim
{
    public interface ICard
    {
        public int GetValue();
        public Card GetFace();
        public bool IsRevealed();
    }
}
