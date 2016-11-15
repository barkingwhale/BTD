using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD.states
{
    class StatePlayerPickCard : IBaseGameState
    {
        public IBaseGameState Update()
        {
            var line = Console.ReadLine();

            return GameStateManager.gameStateEvaluate;
        }
    }
}
