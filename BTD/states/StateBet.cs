using System;

namespace BTD.states
{
    class StateBet : IBaseGameState
    {
        public IBaseGameState Update()
        {
            int credits = Game.Instance.Credits;
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Credit=" + credits.ToString());

            Game.Instance.PrintHand(false);
            return GameStateManager.gameStatePlayerPickCard;
        }
    }
}
