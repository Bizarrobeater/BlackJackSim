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

        Player[] _players;
        PlayerPosition[] _playerPosition;

        Dealer _dealer;
        DealerPosition _dealerPosition;

        Rules _rules;

        public BlackJackTable()
        {
            _dealer = new Dealer();
            _dealerPosition = new DealerPosition();



        }

        public void DealCards()
        {

        }
    }
}
