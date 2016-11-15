using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD.states
{
    class StateBet : IBaseState
    {
        public IBaseState Update()
        {
            int credits = Game.Instance.Credits;
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Credit=" + credits.ToString());
            Console.WriteLine("Dealer: " + "XX...");
            Console.Write("Select: ");
            return GameStateManager.gameStatePlayerPickCard;
        }
    }
}
