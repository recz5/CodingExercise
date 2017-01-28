using System;
using System.Collections.Generic;

namespace PlayingCards.Cards
{
    /// <summary>
    /// Class that generates a set of ranked Diamond card sets
    /// </summary>
    internal class CardsOfDiamonds
    {
        private Suit _suit = Suit.Diamonds;

        private Dictionary<string, Card> _setOfCards = new Dictionary<string, Card>();

        public CardsOfDiamonds()
        {
            FillSetOfCards();
        }

        public Suit Suit
        {
            get { return _suit; }
        }

        public Dictionary<string, Card> SetOfCards
        {
            get { return _setOfCards; }
        }

        private void FillSetOfCards()
        {
            foreach (Rank rnk in Enum.GetValues(typeof(Rank)))
            {
                Card crd = new Card(_suit, rnk);

                _setOfCards.Add(crd.CardName, crd);
            }
        }
    }
}
