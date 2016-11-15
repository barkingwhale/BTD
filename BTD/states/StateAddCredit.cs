using System;

namespace BTD.states
{
    class StateAddCredit : IBaseGameState
    {
        public IBaseGameState Update()
        {
            int creditsAdded = Game.Instance.AddCredits();
            Console.WriteLine("Add credit: " + creditsAdded.ToString());

            return GameStateManager.gameStatePrompt;
        }
    }
}
