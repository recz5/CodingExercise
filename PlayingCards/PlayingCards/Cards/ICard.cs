namespace PlayingCards
{
    /// <summary>
    /// Interface of Card
    /// </summary>
    internal interface ICard
    {
        string CardName { get; }

        int CardSuit { get; }

        int SuitRank { get; }

        int DeckRank { get; set; }
    }
}
