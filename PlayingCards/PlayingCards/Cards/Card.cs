using System;

namespace PlayingCards
{
    /// <summary>
    /// Class that represents a playing card
    /// </summary>
    internal class Card : ICard
    {
        private int _suit;

        private int _rank;

        private int _deckRank = 0;

        private string _name = null;

        /// <summary>
        /// Instantiate a new Card
        /// </summary>
        /// <param name="suit">Type of Suit</param>
        /// <param name="rank">Type of Rank</param>
        public Card(Suit suit, Rank rank)
        {
            _suit = (int)suit;

            _rank = (int)rank;
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

        public int CardSuit
        {
            get
            {
                return _suit;
            }
        }

        public int SuitRank
        {
            get
            {
                return _rank;
            }

        }

        public int DeckRank
        {
            get
            {
                return _deckRank;
            }

            set
            {
                _deckRank = value;
            }
        }

        private void SetName()
        {
            _name = Utilities.SetCardName(this);
        }
    }
}
