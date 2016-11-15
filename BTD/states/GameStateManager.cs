namespace BTD.states
{
    class GameStateManager
    {
        // the game states do not contain any data, so we can statically define them here
        public static StatePrompt           gameStatePrompt = new StatePrompt();
        public static StateQuit             gameStateQuit = new StateQuit();
        public static StateProcessInput     gameStateProcessInput = new StateProcessInput();
        public static StateHelp             gameStateHelp = new StateHelp();
        public static StateAddCredit        gameStateAddCredit = new StateAddCredit();
        public static StateBet              gameStateBet = new StateBet();
        public static StatePlayerPickCard   gameStatePlayerPickCard = new StatePlayerPickCard();
        public static StateEvaluate         gameStateEvaluate = new StateEvaluate();

        // initialize the game to the prompt
        private IBaseGameState m_currentState = gameStatePrompt;

        // singleton to control the GameStateManager instance
        public static GameStateManager Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new GameStateManager();
                }
                return m_instance;
            }
        }
        private static GameStateManager m_instance = null;

        public bool Update()
        {
            m_currentState = m_currentState.Update();

            // if we get to the quit state, we are out of here!
            return m_currentState != gameStateQuit;
        }
    }
}
