using PlayingCards.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards.Decks
{
    public interface IDeck
    {
        Dictionary<int, Card> DeckOfCards { get; }

        void Sort();

        void Shuffle();
    }
}
