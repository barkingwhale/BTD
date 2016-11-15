using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD
{
    class Game
    {
        private static int ADD_CREDITS_AMOUNT = 1000;

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

        public int Credits { get; private set; } = 0;

        private int m_prevBet = 1;
        public int GetPrevBetToDisplay()
        {
            return Math.Min(m_prevBet, Credits);
        }

        public int AddCredits()
        {
            Credits += ADD_CREDITS_AMOUNT;
            if (m_prevBet == 0)
            {
                m_prevBet = 1;
            }
            return ADD_CREDITS_AMOUNT;
        }

        public bool PlacePrevBet()
        {
            return PlaceBet(GetPrevBetToDisplay());
        }

        public bool PlaceBet(int betAmount)
        {
            if (betAmount < 0)
            {
                Console.WriteLine("Nice try.  Please bet a valid amount");
                return false;
            }
            else if (Credits >= betAmount)
            {
                Credits -= betAmount;

                // save off the previous bet.  However, after the turn is over,
                // we will have to revisit this.  If we lost, we may not have enough credits,
                // but if we win, we will
                m_prevBet = betAmount;

                return true;
            }
            else
            {
                Console.WriteLine("Insufficient funds.  Please try again.");
                return false;
            }
        }

    }
}
