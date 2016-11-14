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
            Console.Write("prompt: ");

            return GameStateManager.gameStateProcessInput;
        }
    }
}
