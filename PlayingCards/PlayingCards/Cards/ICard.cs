namespace PlayingCards.Cards
{
    /// <summary>
    /// Interface of Card
    /// </summary>
    internal interface ICard
    {
        string CardName { get; }

        Suit CardSuit { get; }

        Rank CardRank { get; }
    }
}
