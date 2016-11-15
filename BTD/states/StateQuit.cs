using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD.states
{
    class StateQuit : IBaseGameState
    {
        public IBaseGameState Update()
        {
            // we are quiting, so this should not matter, but we need to return something.
            return GameStateManager.gameStateQuit;
        }
    }
}
