using System;

namespace BTD.states
{
    class StateProcessInput : IBaseGameState
    {
        public IBaseGameState Update()
        {
            var line = Console.ReadLine();

            bool bCreditsValid = (Game.Instance.Credits > 0);

            // if the input is numeric, send it along to the bet state, 
            // otherwise, handle the string/characters
            int bet = 0;
            bool parsed = Int32.TryParse(line, out bet);
            if (parsed && bCreditsValid) 
            {
                if (Game.Instance.PlaceBet(bet))
                {
                    return GameStateManager.gameStateBet;
                }
                else
                {
                    return GameStateManager.gameStatePrompt;
                }
            }

            switch (line.ToLower())
            {
                case "":
                    if (bCreditsValid && Game.Instance.PlacePrevBet())
                    {
                        return GameStateManager.gameStateBet;
                    }
                    else
                    {
                        // FIXME... refactor this
                        Console.WriteLine("Invalid input. Please try again");
                        return GameStateManager.gameStatePrompt;
                    }

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
