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
            Dealer dealer = new Dealer(new StandardDeck());

            Assert.AreNotEqual(null, dealer);

            Assert.AreNotEqual(null, dealer.DeckOfCards);

            dealer.Shuffle();

            int i = 0;

            int ordered = 0;

            int unordered = 0;

            foreach (var cards in dealer.DeckOfCards)
            {
                i++;

                if (i == cards.Value.DeckRank)
                    ordered++;
                else
                    unordered++;
            }

            Assert.AreNotEqual(dealer.DeckOfCards.Count, ordered);

            Assert.AreEqual(true, unordered > ordered);

        }

        [TestMethod]
        [TestCategory("Decks")]
        public void StandardDeck_Sort()
        {
            Dealer dealer = new Dealer(new StandardDeck());

            Assert.AreNotEqual(null, dealer);

            Assert.AreNotEqual(null, dealer.DeckOfCards);

            dealer.Shuffle();

            dealer.Sort();

            int i = 0;

            int ordered = 0;

            int unordered = 0;

            foreach (var cards in dealer.DeckOfCards)
            {
                i++;

                if (i == cards.Value.DeckRank)
                    ordered++;
                else
                    unordered++;
            }      

            Assert.AreEqual(dealer.DeckOfCards.Count, ordered);

            Assert.AreEqual(true, unordered < ordered);

            Assert.AreEqual(true, unordered == 0);

            Assert.AreEqual(true, ordered == 52);
        }


        [TestMethod]
        [TestCategory("Decks")]
        public void StandardDeck_DeckOfCards()
        {
            Dealer dealer = new Dealer(new StandardDeck());

            Assert.AreEqual(52,dealer.DeckOfCards.Count);
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
