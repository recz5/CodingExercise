using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayingCards;

namespace TestPlayingCards
{
    [TestClass]
    public class PlayingCardsTests
    {
        [TestMethod]
        [TestCategory("Cards")]
        public void Card()
        {
            Suit suit = Suit.Spades;

            Rank rnk = Rank.King;

            Card crd = new Card(suit, rnk);

            Assert.AreEqual((int)suit, crd.CardSuit);

            Assert.AreEqual((int)rnk, crd.SuitRank);

            Assert.AreEqual(0, crd.DeckRank);

            Assert.AreEqual(String.Format("{0} of {1}",rnk, suit), crd.CardName);

        }


        [TestMethod]
        [TestCategory("Decks")]
        public void StandardDeck_Shuffle()
        {
            StandardDeck sd = new StandardDeck();

            Assert.AreNotEqual(null, sd);

            Assert.AreNotEqual(null, sd.DeckOfCards);

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

            Assert.AreNotEqual(sd.DeckOfCards.Count, ordered);

            Assert.AreEqual(true, unordered > ordered);

        }

        [TestMethod]
        [TestCategory("Decks")]
        public void StandardDeck_Sort()
        {
            StandardDeck sd = new StandardDeck();

            Assert.AreNotEqual(null, sd);

            Assert.AreNotEqual(null, sd.DeckOfCards);

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

            Assert.AreEqual(sd.DeckOfCards.Count, ordered);

            Assert.AreEqual(true, unordered < ordered);

            Assert.AreEqual(true, unordered == 0);

            Assert.AreEqual(true, ordered == 52);
        }


        [TestMethod]
        [TestCategory("Decks")]
        public void StandardDeck_DeckOfCards()
        {
            StandardDeck sd = new StandardDeck();

            Assert.AreEqual(52, sd.DeckOfCards.Count);
        }

        [TestMethod]
        [TestCategory("Dealers")]
        public void Dealer()
        {
            Dealer dealer = new Dealer(new StandardDeck());

            var shuffle = dealer.GetType().GetMethod("Shuffle");

            Assert.AreNotEqual(null, shuffle);

            var sort = dealer.GetType().GetMethod("Sort");

            Assert.AreNotEqual(null, sort);

            var theDeck = dealer.GetType().GetProperty("DeckOfCards");

            Assert.AreNotEqual(null, theDeck);

        }

        [TestMethod]
        [TestCategory("Dealers")]
        public void Dealer_Features()
        {
            Dealer dealer = new Dealer(new StandardDeck());

            Assert.AreNotEqual(null, dealer);

            Assert.AreNotEqual(null, dealer.DeckOfCards);

            try
            {
                dealer.Shuffle();

                Assert.AreNotEqual(null, dealer.DeckOfCards);

            }
            catch
            {
                Assert.Fail("Failed to shuffle the deck!");
            }

            try
            {
                dealer.Sort();

                Assert.AreNotEqual(null, dealer.DeckOfCards);

            }
            catch
            {
                Assert.Fail("Failed to sort the deck!");
            }
        }


        [TestMethod]
        [TestCategory("Utility")]
        public void Utilities_SetCardName()
        {
            string result = Utilities.SetCardName(new PlayingCards.Card(Suit.Hearts, Rank.King));

            Assert.AreEqual("King of Hearts", result);
        }

    }
}
