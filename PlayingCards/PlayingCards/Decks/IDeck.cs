using System.Collections.Generic;

namespace PlayingCards
{
    internal interface IDeck
    {
        Dictionary<int, Card> DeckOfCards { get; }

        void Sort();

        void Shuffle();
    }
}
