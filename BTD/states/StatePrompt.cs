using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD.states
{
    class StatePrompt : IBaseState
    {
        public IBaseState Update()
        {
            // FIXME for the credits
            int credits = 0;
            Console.WriteLine("Credit=" + credits.ToString());
            Console.Write("(H)elp, (A)dd Credit, (Q)uit: ");

            return GameStateManager.gameStateProcessInput;
        }
    }
}
