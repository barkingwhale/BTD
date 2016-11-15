using System;

namespace BTD.states
{
    class StateEvaluate : IBaseGameState
    {
        public IBaseGameState Update()
        {
            Game.WinInfo winInfo = Game.Instance.EvaluateWin();
            switch (winInfo.WinType)
            {
                case Game.WinInfo.EWinType.DEALER_WIN:
                    Console.WriteLine("Dealer Wins!");
                    break;
                case Game.WinInfo.EWinType.PUSH:
                    Console.Write("Push! Win=");
                    Console.WriteLine(winInfo.WinAmount);
                    break;
                case Game.WinInfo.EWinType.PLAYER_WIN:
                    Console.Write("Player Wins! Win=");
                    Console.WriteLine(winInfo.WinAmount);
                    break;
            }

            return GameStateManager.gameStatePrompt;
        }
    }
}
