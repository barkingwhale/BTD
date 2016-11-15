using System;

namespace BTD
{
    class Game
    {
        private static int ADD_CREDITS_AMOUNT = 1000;
        private static int NUM_PLAYER_CARDS = 4;

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

        public enum EWinType
        {
            DEALER_WIN = 0,
            PUSH,
            PLAYER_WIN
        }
            

        public int Credits { get; private set; } = 0;
        public int Bet { get; private set; } = 0;
        public int PlayerSelection { get; set; }

        private PlayingCard dealerCard;
        private PlayingCard[] playerCards = new PlayingCard[NUM_PLAYER_CARDS];

        private CardDeck cardDeck = new CardDeck();

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
                Bet = betAmount;

                // save off the previous bet.  However, after the turn is over,
                // we will have to revisit this.  If we lost, we may not have enough credits,
                // but if we win, we will
                m_prevBet = betAmount;

                // FIXME... move this
                // new game is starting... shuffle the cards again
                cardDeck.ShuffleCards();
                dealerCard = cardDeck.Cards[0];
                for (int i = 0; i < 4; ++i)
                {
                    playerCards[i] = cardDeck.Cards[i + 1];
                }
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient funds.  Please try again.");
                return false;
            }
        }

        public void PrintHand(bool bReveal)
        {
            Console.Write("Dealer: ");
            Console.Write(dealerCard.ToString());
            Console.Write(", Player: ");
            for( int i = 1; i <= 4; ++i)
            {
                // FIXME, validate PlayerSelection
                bool bSelection = (i == PlayerSelection);
                if(bSelection && bReveal)
                {
                    Console.Write("<");
                }
                if(bReveal)
                {
                    Console.Write(playerCards[i-1].ToString());
                }
                else
                {
                    Console.Write("**");
                }
                if (bSelection && bReveal)
                {
                    Console.Write(">");
                }
                Console.Write(" ");
            }
            Console.Write(Environment.NewLine);
        }

        public EWinType EvaluateWin()
        {
            PlayingCard playerCard = playerCards[PlayerSelection - 1];
            if (dealerCard == playerCard)
            {
                Credits += Bet;
                return EWinType.PUSH;
            }
            else if (dealerCard > playerCard)
            {
                return EWinType.DEALER_WIN;
            }
            else
            {
                Credits += Bet * 2;
                return EWinType.PLAYER_WIN;
            }
        }
    }
}
