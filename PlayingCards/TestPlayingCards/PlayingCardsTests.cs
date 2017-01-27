using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayingCards;

namespace TestPlayingCards
{
    [TestClass]
    public class PlayingCardsTests
    {
        [TestMethod]
        public void CardTest()
        {
            //Card card1 = new Card(Suit.Spades, Rank.Ace);

            //Assert.AreEqual("Ace of Spades", card1.Name);

            Card card2 = new Card();

            card2.CardSuit = Suit.Spades;

            card2.CardRank = Rank.Ace;

            Assert.AreEqual("Ace of Spades", card2.Name);
        }
    }
}
