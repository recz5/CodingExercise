using System.Collections.Generic;

namespace PlayingCards
{
    /// <summary>
    /// Standard deck of 52 playing cards (four suits of thirteen cards each)
    /// </summary>
    public class Dealer : IDeck
    {
        private IDeck _deck;

        public Dealer(IDeck deck)
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

        public Dictionary<int, Card> DeckOfCards
        {
            get { return _deck.DeckOfCards; }
        }


    }
}
