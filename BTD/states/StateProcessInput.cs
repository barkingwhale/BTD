using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD.states
{
    class StateProcessInput : IBaseState
    {
        public IBaseState Update()
        {
            var line = Console.ReadLine();
            switch (line.ToLower())
            {
                case "q":
                    // TODO.  does this statement belong in it's own state??
                    Console.WriteLine("Thanks for playing!");
                    return GameStateManager.gameStateQuit;

                case "h":
                    return GameStateManager.gameStateHelp;

                default:
                    // TODO.  does this statement belong in it's own state??
                    Console.WriteLine("Invalid input. Please try again");
                    return GameStateManager.gameStatePrompt;
            }
        }
    }
}
