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

        [Fact]
        public void StandardDeck_Shuffle()
        {
            StandardDeck sd = new StandardDeck();

            Assert.NotEqual(null, sd);

            Assert.NotEqual(null, sd.DeckOfCards);

            sd.Shuffle();

            int i = 0;

            int ordered = 0;

            int unordered = 0;

            foreach (var cards in sd.DeckOfCards)
            {
                i++;

                if (i == cards.Value.DeckRank)
                    ordered++;
                else
                    unordered++;
            }

            Assert.NotEqual(sd.DeckOfCards.Count, ordered);

            Assert.Equal(true, unordered > ordered);

        }

        [Fact]
        public void StandardDeck_Sort()
        {
            StandardDeck sd = new StandardDeck();

            Assert.NotEqual(null, sd);

            Assert.NotEqual(null, sd.DeckOfCards);

            sd.Shuffle();

            sd.Sort();

            int i = 0;

            int ordered = 0;

            int unordered = 0;

            foreach (var cards in sd.DeckOfCards)
            {
                i++;

                if (i == cards.Value.DeckRank)
                    ordered++;
                else
                    unordered++;
            }

            Assert.Equal(sd.DeckOfCards.Count, ordered);

            Assert.Equal(true, unordered < ordered);

            Assert.Equal(true, unordered == 0);

            Assert.Equal(true, ordered == 52);
        }


        [Fact]
        public void StandardDeck_DeckOfCards()
        {
            StandardDeck sd = new StandardDeck();

            Assert.Equal(52, sd.DeckOfCards.Count);
        }

        [Fact]
        public void Dealer()
        {
            Dealer dealer = new Dealer(new StandardDeck());

            var shuffle = dealer.GetType().GetMethod("Shuffle");

            Assert.NotEqual(null, shuffle);

            var sort = dealer.GetType().GetMethod("Sort");

            Assert.NotEqual(null, sort);

            var theDeck = dealer.GetType().GetProperty("DeckOfCards");

            Assert.NotEqual(null, theDeck);

        }

        [Fact]
        public void Dealer_Features()
        {
            Dealer dealer = new Dealer(new StandardDeck());

            Assert.NotEqual(null, dealer);

            Assert.NotEqual(null, dealer.DeckOfCards);

            try
            {
                dealer.Shuffle();

                Assert.NotEqual(null, dealer.DeckOfCards);

            }
            catch
            {
                Assert.True(false,"Failed to shuffle the deck!");
            }

            try
            {
                dealer.Sort();

                Assert.NotEqual(null, dealer.DeckOfCards);

            }
            catch
            {
                Assert.True(false, "Failed to sort the deck!");
            }
        }


        [Fact]
        public void Utilities_SetCardName()
        {
            string result = Utilities.SetCardName(new PlayingCards.Card(Suit.Hearts, Rank.King));

            Assert.Equal("King of Hearts", result);
        }

    }
}
