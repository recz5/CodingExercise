using PlayingCards.Cards;
using System;
using System.Collections.Generic;

namespace PlayingCards.Decks
{
    /// <summary>
    /// Standard deck of 52 playing cards (four suits of thirteen cards each)
    /// </summary>
    public class StandardDeck
    {
        private IDeck _deck;

        private Dictionary<int, Card> _cards = new Dictionary<int, Card>();

        public StandardDeck(IDeck deck)
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
