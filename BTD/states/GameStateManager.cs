using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD.states
{
    class GameStateManager
    {
        public static StatePrompt gameStatePrompt = new StatePrompt();
        public static StateQuit gameStateQuit = new StateQuit();
        public static StateProcessInput gameStateProcessInput = new StateProcessInput();

        // initialize the game to the prompt
        private IBaseState m_currentState = gameStatePrompt;

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
