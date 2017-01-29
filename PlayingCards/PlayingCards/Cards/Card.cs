namespace PlayingCards
{
    /// <summary>
    /// Class that represents a playing card
    /// </summary>
    public class Card : ICard
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
        internal Card(Suit suit, Rank rank)
        {
            _suit = (int)suit;

            _rank = (int)rank;
        }

        /// <summary>
        /// Card's name in format of {"Rank" of "Suit"} e.g. Ace of Spades
        /// </summary>
        public string CardName
        {
            get
            {
                if (_name == null)
                    SetName();
                return _name;

            }
        }

        /// <summary>
        /// Index of Card's Suit in a Enum List
        /// </summary>
        public int CardSuit
        {
            get
            {
                return _suit;
            }
        }

        /// <summary>
        /// Index of Card's Rank in a Enum List
        /// </summary>
        public int SuitRank
        {
            get
            {
                return _rank;
            }

        }

        /// <summary>
        /// Index of Card's Rank in a deck of 52 cards
        /// </summary>
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

        /// <summary>
        /// Sets the name of the card
        /// </summary>
        private void SetName()
        {
            _name = Utilities.SetCardName(this);
        }
    }
}
