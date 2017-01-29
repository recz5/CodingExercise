using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PlayingCards;

namespace TestPlayingCards_xUnit
{
    public class PlayingCardsTest_xUnit
    {
        [Fact]
        public void Card()
        {
            Suit suit = Suit.Spades;

            Rank rnk = Rank.King;

            Card crd = new Card(suit, rnk);

            Assert.Equal((int)suit, crd.CardSuit);

            Assert.Equal((int)rnk, crd.SuitRank);

            Assert.Equal(0, crd.DeckRank);

            Assert.Equal(String.Format("{0} of {1}", rnk, suit), crd.CardName);
        }
    }
}
