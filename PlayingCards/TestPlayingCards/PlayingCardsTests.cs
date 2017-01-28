using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayingCards;
using PlayingCards.Cards;
using PlayingCards.Decks;

namespace TestPlayingCards
{
    [TestClass]
    public class PlayingCardsTests
    {
        [TestMethod]
        [TestCategory("CardsNamespace")]
        public void Card()
        {
            Suit suit = Suit.Spades;
            Rank rnk = Rank.King;


            Card crd = new Card(suit, rnk);

            Assert.AreEqual(suit, crd.CardSuit);

            Assert.AreEqual(rnk, crd.CardRank);

            Assert.AreEqual(String.Format("{0} of {1}",rnk, suit), crd.CardName);

        }

        [TestMethod]
        [TestCategory("CardsNamespace")]
        public void CardOfSpades()
        {
            CardsOfSpades spades = new CardsOfSpades();

            Assert.AreEqual(Suit.Spades, spades.Suit);

            Assert.AreEqual(Enum.GetValues(typeof(Rank)).Length, spades.SetOfCards.Count);

        }

        [TestMethod]
        [TestCategory("CardsNamespace")]
        public void CardOfHearts()
        {
            CardsOfHearts spades = new CardsOfHearts();

            Assert.AreEqual(Suit.Hearts, spades.Suit);

            Assert.AreEqual(Enum.GetValues(typeof(Rank)).Length, spades.SetOfCards.Count);
        }

        [TestMethod]
        [TestCategory("CardsNamespace")]
        public void CardOfDiamonds()
        {
            CardsOfDiamonds spades = new CardsOfDiamonds();

            Assert.AreEqual(Suit.Diamonds, spades.Suit);

            Assert.AreEqual(Enum.GetValues(typeof(Rank)).Length, spades.SetOfCards.Count);
        }

        [TestMethod]
        [TestCategory("CardsNamespace")]
        public void CardOfClubs()
        {
            CardsOfClubs spades = new CardsOfClubs();

            Assert.AreEqual(Suit.Clubs, spades.Suit);

            Assert.AreEqual(Enum.GetValues(typeof(Rank)).Length, spades.SetOfCards.Count);
        }

        [TestMethod]
        [TestCategory("DecksNamespace")]
        public void StandardDeck()
        {
            StandardDeck deck = new StandardDeck(new Deck());

            var test = deck.DeckOfCards;

            //deck.Shuffle();

            //deck.Sort();

            //foreach (var card in deck.DeckOfCards)
            //{
                
            //}         

        }

        [TestMethod]
        [TestCategory("Utility")]
        public void Utilities_SetCardName()
        {
            string result = Utilities.SetCardName(new PlayingCards.Cards.Card(Suit.Hearts, Rank.King));

            Assert.AreEqual("King of Hearts", result);
        }


    }
}
