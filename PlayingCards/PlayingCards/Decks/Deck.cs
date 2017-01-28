using PlayingCards.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards.Decks
{
    internal class Deck : IDeck
    {
        private Dictionary<int, Card> _cards = new Dictionary<int, Card>();

        public Dictionary<int, Card> DeckOfCards
        {
            get
            {
                if (_cards.Count == 0)
                    CreateStandardDeck();
                return _cards;
            }
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        private void CreateStandardDeck()
        {
            CardsOfSpades spades = new CardsOfSpades();

            CardsOfHearts hearts = new CardsOfHearts();

            int i = 0;

            foreach (var crd in spades.SetOfCards)
            {
                _cards.Add(i++, crd.Value);
            }
        }
    }
}
