using PlayingCards;
using System;

namespace PlayingCards
{
    /// <summary>
    /// Helper Class
    /// </summary>
    public static class Utilities
    {
        /// <summary>
        /// Generates string card's name
        /// </summary>
        /// <param name="card">Card Class</param>
        /// <returns></returns>
        internal static string SetCardName(Card card)
        {
            return String.Format("{0} of {1}", (Rank)card.SuitRank, (Suit)card.CardSuit);
        }
    }
}
