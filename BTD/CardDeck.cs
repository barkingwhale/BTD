using System;
using System.Collections.Generic;
using System.Text;

namespace BTD
{
    class CardDeck
    {
        // just used for validation
        private static int NUM_CARDS = 52;

        // list of cards that comprizes a deck of cards
        public List<PlayingCard> Cards { get; private set; } = new List<PlayingCard>();

        // constructor 
        public CardDeck()
        {
            Init();
        }

        // intializes the deck with values and suits in order.
        public void Init()
        {
            // build the card deck in order
            foreach (PlayingCard.ESuits suit in Enum.GetValues(typeof(PlayingCard.ESuits)))
            {
                foreach (PlayingCard.EValues value in Enum.GetValues(typeof(PlayingCard.EValues)))
                {
                    PlayingCard card = new PlayingCard(value, suit);
                    Cards.Add(card);
                }
            }
            System.Diagnostics.Debug.Assert(Cards.Count == NUM_CARDS);
        }

        public List<PlayingCard> GetCardsForHand(int numCards)
        {
            // this assumes a fresh shuffle for every hand.  Could re-implement and give the next numCards
            // and shuffle when it get's low
            ShuffleCards();

            List<PlayingCard> hand = new List<PlayingCard>(numCards);
            hand = Cards.GetRange(0, numCards);
            return hand;
        }

        private void ShuffleCards()
        {
            Random rand = new Random();

            // iterate through the cards from the back to the front.  we do not have to
            // go all the way to 0, because we will not swap with ourself
            for (int i = Cards.Count - 1; i > 0; --i)
            {
                // pull a randIndex that is from 0 to the current card
                int randIndex = rand.Next(i);

                // don't need to swap with ourself
                if (randIndex != i)
                {
                    var temp = Cards[i];
                    Cards[i] = Cards[randIndex];
                    Cards[randIndex] = temp;
                }
            }
        }
    }
}
