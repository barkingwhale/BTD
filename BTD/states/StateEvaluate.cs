﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD.states
{
    class StateEvaluate : IBaseState
    {
        public IBaseState Update()
        {
            Console.WriteLine("Dealer Wins!");
            return GameStateManager.gameStatePrompt;
        }
    }
}
