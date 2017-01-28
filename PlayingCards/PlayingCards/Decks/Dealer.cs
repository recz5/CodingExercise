using System.Collections.Generic;

namespace PlayingCards
{
    /// <summary>
    /// Standard deck of 52 playing cards (four suits of thirteen cards each)
    /// </summary>
    public class Dealer
    {
        private IDeck _deck;

        internal Dealer(IDeck deck)
        {
            _deck = deck;
        }

        public void Shuffle()
        {
            _deck.Shuffle();
        }

        public void Sort()
        {
            _deck.Sort();
        }

        internal Dictionary<int, Card> DeckOfCards
        {
            get { return _deck.DeckOfCards; }
        }


    }
}
