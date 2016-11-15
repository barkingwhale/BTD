﻿using System;
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

            int selection = 0;
            bool parsed = Int32.TryParse(line, out selection);
            // FIXME... hardcoded 4
            if (parsed && ((selection > 0) && (selection <= 4)))
            {
                return GameStateManager.gameStateEvaluate;
            }
            else
            {
                // FIXME... refactor
                Console.WriteLine("Invalid choice, please choose again");
                Console.Write("Select: ");
                return GameStateManager.gameStatePlayerPickCard;
            }
        }
    }
}
