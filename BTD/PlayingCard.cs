using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD
{
    class PlayingCard
    {
        // enum of possible values for a playing card
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
        // enum of possible suits for a playing card
        public enum ESuits
        {
            C = 0,
            D,
            H,
            S,
        }

        public EValues Value { get; private set; }
        public ESuits Suit { get; private set; }

        // constructor
        public PlayingCard(EValues value, ESuits suit)
        {
            Value = value;
            Suit = suit;
        }

        // formats the string representation of the card
        public override string ToString()
        {
            StringBuilder cardName = new StringBuilder(Value.ToString() + Suit.ToString());
            cardName.Remove(0, 1); // remove the underscore from the value enum
            return cardName.ToString();
        }

        // define the operators we will use for evaluating hands
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
        public override bool Equals(object obj)
        {
            PlayingCard cardObj = obj as PlayingCard;
            return (cardObj == this);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
