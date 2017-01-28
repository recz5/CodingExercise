using System;

namespace PlayingCards.Cards
{
    /// <summary>
    /// Class that represents a playing card
    /// </summary>
    public class Card : ICard
    {
        private Suit _suit;

        private Rank _rank;

        private string _name = null;

        /// <summary>
        /// Instantiate a new Card
        /// </summary>
        /// <param name="suit">Type of Suit</param>
        /// <param name="rank">Type of Rank</param>
        public Card(Suit suit, Rank rank)
        {
            _suit = suit;

            _rank = rank;
        }

        public string CardName
        {
            get
            {
                if (_name == null)
                    SetName();
                return _name;

            }
        }

        public Suit CardSuit
        {
            get
            {
                return _suit;
            }
        }

        public Rank CardRank
        {
            get
            {
                return _rank;
            }
        }

        private void SetName()
        {
            _name = Utilities.SetCardName(this);
        }
    }
}
