using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD.states
{
    class StatePlayerPickCard : IBaseState
    {
        public IBaseState Update()
        {
            var line = Console.ReadLine();

            return GameStateManager.gameStateEvaluate;
        }
    }
}
