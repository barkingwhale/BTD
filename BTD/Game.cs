using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD
{
    class Game
    {
        public static Game Instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new Game();
                }
                return m_instance;
            }
        }
        private static Game m_instance = null;




    }
}
