using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayingCards
{
    public class StandardDeck : IDeck
    {
        private Dictionary<int, Card> _cards = new Dictionary<int, Card>();

        public StandardDeck()
        {
            if (_cards.Count == 0)
                CreateStandardDeck();
        }
        
        /// <summary>
        /// Collection of 52 Cards (four suits of thirteen cards each)
        /// </summary>
        public Dictionary<int, Card> DeckOfCards
        {
            get
            {
                return _cards;
            }
        }

        /// <summary>
        /// Shuffles the deck of cards randomly
        /// </summary>
        public void Shuffle()
        {
            Random rdm = new Random();

            _cards = _cards.OrderBy(x => rdm.Next()).ToDictionary(z => z.Key, z => z.Value) ;
        }

        /// <summary>
        /// Sorts the deck of cards in ascending order
        /// </summary>
        public void Sort()
        {
            _cards = _cards.OrderBy(x => x.Value.DeckRank).ToDictionary(z => z.Key, z => z.Value);
        }

        /// <summary>
        /// Create a deck of 52 cards based on Suit and Rank Enum Lists
        /// Suit and Rank are in ascending order
        /// </summary>
        private void CreateStandardDeck()
        {
            int i = 0;

            foreach (Rank sr in Enum.GetValues(typeof(Rank)))
            {
                foreach (Suit st in Enum.GetValues(typeof(Suit)))
                {
                    i++;
                    Card crd = new Card(st, sr);
                    crd.DeckRank = i;
                    _cards.Add(i, crd);
                }
            }
        }
    }
}
