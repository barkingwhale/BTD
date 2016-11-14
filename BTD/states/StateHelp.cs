using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD.states
{
    class StateHelp : IBaseState
    {
        string helpText = @"
                ***Beat the Dealer ***
Enter the amount you wish to bet.
5 cards will be dealt.
The first card is the dealer card and is dealt face - up.
The remaining 4 cards will be dealt face - down.
Enter the position of one of the face - down cards.
  If your card is higher than the dealer card, you win twice your
bet.
If your card is of the same value, you win your bet back.
Aces are high!
Good Luck!";

        public IBaseState Update()
        {
            Console.Write(helpText);
            return GameStateManager.gameStatePrompt;
        }
    }
}
