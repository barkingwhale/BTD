using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD.states
{
    class StateAddCredit : IBaseState
    {
        public IBaseState Update()
        {
            // FIXME implement
            Console.WriteLine("IMPLEMENT adding credits!");
            return GameStateManager.gameStatePrompt;
        }
    }
}
