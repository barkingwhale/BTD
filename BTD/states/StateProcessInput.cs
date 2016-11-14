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

            // if the input is numeric, send it along to the bet state, 
            //otherwise, handle the string/characters
            if (line.All(char.IsDigit))
            {
                return GameStateManager.gameStateBet;
            }

            switch (line.ToLower())
            {
                case "a":
                    return GameStateManager.gameStateAddCredit;

                case "h":
                    return GameStateManager.gameStateHelp;

                case "q":
                    // TODO.  does this statement belong in it's own state??
                    Console.WriteLine("Thanks for playing!");
                    return GameStateManager.gameStateQuit;

                default:
                    // TODO.  does this statement belong in it's own state??
                    Console.WriteLine("Invalid input. Please try again");
                    return GameStateManager.gameStatePrompt;
            }
        }
    }
}
