﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD
{
    class PlayingCard
    {
        public enum EValues
        {
            _2 = 0,
            _3,
            _4,
            _5,
            _6,
            _7,
            _8,
            _9,
            _T,
            _J,
            _Q,
            _K,
            _A,
        }
        public enum ESuits
        {
            C = 0,
            D,
            H,
            S,
        }

        public EValues Value { get; private set; }
        public ESuits Suit { get; private set; }

        public PlayingCard(EValues value, ESuits suit)
        {
            Value = value;
            Suit = suit;
        }

        public string GetCardName()
        {
            StringBuilder cardName = new StringBuilder(Value.ToString() + Suit.ToString());
            cardName.Remove(0, 1); // remove the underscore from the value enum
            return cardName.ToString();
        }

        public static bool operator <(PlayingCard lhs, PlayingCard rhs)
        {
            // for comparison, we only care about value, not about suit
            return (lhs.Value < rhs.Value);
        }
        public static bool operator >(PlayingCard lhs, PlayingCard rhs)
        {
            // opposite of <
            return !(lhs < rhs);
        }
        public static bool operator <=(PlayingCard lhs, PlayingCard rhs)
        {
            // for comparison, we only care about value, not about suit
            return (lhs.Value <= rhs.Value);
        }
        public static bool operator >=(PlayingCard lhs, PlayingCard rhs)
        {
            // opposite of <=
            return !(lhs <= rhs);
        }
        public static bool operator ==(PlayingCard lhs, PlayingCard rhs)
        {
            // for comparison, we only care about value, not about suit
            return (lhs.Value == rhs.Value);
        }
        public static bool operator !=(PlayingCard lhs, PlayingCard rhs)
        {
            // opposite of ==
            return !(lhs == rhs);
        }
    }

    class CardDeck
    {
        private static int NUM_CARDS = 52;

        private List<PlayingCard> m_cards;
        public void Init()
        {
            // build the card deck in order
            foreach (PlayingCard.ESuits suit in Enum.GetValues(typeof(PlayingCard.ESuits)))
            {
                foreach (PlayingCard.EValues value in Enum.GetValues(typeof(PlayingCard.EValues)))
                {
                    PlayingCard card = new PlayingCard(value, suit);
                    m_cards.Add(card);
                }
            }
            System.Diagnostics.Debug.Assert(m_cards.Count == NUM_CARDS);
        }

        public void ShuffleCards()
        {
            Random rand = new Random();

            // iterate through the cards from the back to the front.  we do not have to
            // go all the way to 0, because we will not swap with ourself
            for( int i = m_cards.Count-1; i < 0; --i)
            {
                // pull a randIndex that is from 0 to the current card
                int randIndex = rand.Next(i);

                // don't need to swap with ourself
                if (randIndex != i)
                {
                    var temp = m_cards[i];
                    m_cards[i] = m_cards[randIndex];
                    m_cards[randIndex] = temp;
                }
            }
        }
    }
}
