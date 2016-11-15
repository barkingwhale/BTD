using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.Write("Select: ");
            return GameStateManager.gameStatePlayerPickCard;
        }
    }
}
