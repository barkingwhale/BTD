using System;

namespace BTD.states
{
    class StateAddCredit : IBaseGameState
    {
        public IBaseGameState Update()
        {
            Console.Write("Add credit: ");
            var line = Console.ReadLine();

            // parse the input to see if it's numeric and > 0
            int credits = 0;
            bool parsed = Int32.TryParse(line, out credits);
            if (parsed && credits > 0)
            {
                Game.Instance.AddCredits(credits);
                return GameStateManager.gameStatePrompt;
            }

            // if we get here, we had invalid input -- try again
            Console.WriteLine("Invalid input. Please try again");
            return GameStateManager.gameStateAddCredit;
        }
    }
}
