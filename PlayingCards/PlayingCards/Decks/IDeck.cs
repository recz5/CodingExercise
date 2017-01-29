using System.Collections.Generic;

namespace PlayingCards
{
    public interface IDeck
    {
        Dictionary<int, Card> DeckOfCards { get; }

        void Sort();

        void Shuffle();

    }
}
