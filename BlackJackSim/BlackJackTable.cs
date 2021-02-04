using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackSim
{
    class BlackJackTable
    {
        CardShoe _shoe;
        List<Card> _discards;

        IPosition[] _positions;
        Player[] _players;

        Dealer _dealer;

        Rules _rules;

        List<ITableObserver> _tableObservers;

        public BlackJackTable()
        {
            _positions = new IPosition[8];
            _positions[0] = new DealerPosition();
            _dealer = new Dealer();
        }

        public void DealCards()
        {

        }
    }
}
