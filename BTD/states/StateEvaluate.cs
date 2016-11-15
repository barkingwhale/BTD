using System;

namespace BTD.states
{
    class StateEvaluate : IBaseGameState
    {
        public IBaseGameState Update()
        {
            Game.EWinType winType = Game.Instance.EvaluateWin();
            switch (winType)
            {
                case Game.EWinType.DEALER_WIN:
                    Console.WriteLine("Dealer Wins!");
                    break;
                case Game.EWinType.PUSH:
                    Console.WriteLine("Push!");
                    break;
                case Game.EWinType.PLAYER_WIN:
                    //FIXME add win amount
                    Console.WriteLine("Player Wins!");
                    break;
            }

            return GameStateManager.gameStatePrompt;
        }
    }
}
