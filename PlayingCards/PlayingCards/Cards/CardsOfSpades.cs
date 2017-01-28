using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards.Cards
{
    /// <summary>
    /// Class that generates a set of ranked Spade card sets
    /// </summary>
    internal class CardsOfSpades
    {
        private Suit _suit = Suit.Spades;

        private Dictionary<string, Card> _setOfCards = new Dictionary<string, Card>();

        public CardsOfSpades()
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
