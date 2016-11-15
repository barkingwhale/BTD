﻿using System;

namespace BTD.states
{
    class StatePrompt : IBaseGameState
    {
        public IBaseGameState Update()
        {
            int credits = Game.Instance.Credits;
            int prevBet = Game.Instance.GetPrevBetToDisplay();
            Console.WriteLine("Credit=" + credits.ToString());
            Console.Write("(H)elp, (A)dd Credit, (Q)uit");
            if (credits > 0)
            {
                Console.Write(" or enter bet[" + prevBet.ToString() + "]");
            }
            Console.Write(": ");

            return GameStateManager.gameStateProcessInput;
        }
    }
}
