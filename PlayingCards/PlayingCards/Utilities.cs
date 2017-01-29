namespace PlayingCards
{
    /// <summary>
    /// Helper Class
    /// </summary>
    internal static class Utilities
    {
        /// <summary>
        /// Generates string card's name
        /// </summary>
        /// <param name="card">Card Class</param>
        /// <returns></returns>
        internal static string SetCardName(Card card)
        {
            //return String.Format("{0} of {1}", (Rank)card.SuitRank, (Suit)card.CardSuit);
            return string.Concat((Rank)card.SuitRank, " of ", (Suit)card.CardSuit);
        }
    }
}
