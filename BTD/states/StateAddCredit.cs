﻿using System;
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
            int creditsAdded = Game.Instance.AddCredits();
            Console.WriteLine("Add credit: " + creditsAdded.ToString());

            return GameStateManager.gameStatePrompt;
        }
    }
}
