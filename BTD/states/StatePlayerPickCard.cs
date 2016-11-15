using System;

namespace BTD.states
{
    class StatePlayerPickCard : IBaseGameState
    {
        private bool IsSelectionValid(int selection)
        {
            return ((selection > 0) && (selection <= Game.NUM_PLAYER_CARDS));
        }

        // FIXME.. refactor prevSelection
        public IBaseGameState Update()
        {
            Console.Write("Select");
            int prevSelection = Game.Instance.PlayerSelection;
            if (IsSelectionValid(prevSelection))
            {
                Console.Write("[" + prevSelection.ToString() + "]");
            }
            Console.Write(": ");
            var line = Console.ReadLine();

            int newSelection = 0;
            bool parsed = Int32.TryParse(line, out newSelection);

            if (parsed && IsSelectionValid(newSelection))
            {
                Game.Instance.PlayerSelection = newSelection;
                Game.Instance.PrintHand(true);
                return GameStateManager.gameStateEvaluate;
            }
            else if (line.Equals("") && IsSelectionValid(prevSelection))
            {
                Game.Instance.PrintHand(true);
                return GameStateManager.gameStateEvaluate;
            }
            else
            {
                // FIXME... invalid state?
                Console.WriteLine("Invalid choice, please choose again");
                return GameStateManager.gameStatePlayerPickCard;
            }
        }
    }
}
