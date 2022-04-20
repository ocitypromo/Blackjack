using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blackjack.Test.ComponentTests
{
    [TestClass]
    public class DeckTest

    {
        [TestMethod]
        public void TestDeckGenerates52Cards()
        {
            Deck deck = new Deck();

            Assert.AreEqual(deck.NumberOfCardsInDeck, 52);
        }

        [TestMethod]
        public void TestDeckDrawsCards()
        {
            Deck deck = new Deck();

            Card? card = deck.Draw();

            Assert.IsNotNull(card);

            Assert.AreEqual(deck.NumberOfCardsInDeck, 51);

        }

        [TestMethod]
        public void TestDeckShuffle()
        {
            //If you have a variable storing a reference to A, and you pass that variable (reference) to A, and your function changes A, then the data in your variable changes too.
            //This is something to be aware of when dealing with reference types. You're passing references, not the object or value. 
            //Here we are using the list to test the shuffle by comparing list of cards to shuffled deck 
            List<Card> cards = new List<Card>();
            cards.Add(new Card(Card.CardSuit.Diamonds, Card.CardRank.Ace));
            cards.Add(new Card(Card.CardSuit.Hearts, Card.CardRank.King));
            cards.Add(new Card(Card.CardSuit.Diamonds, Card.CardRank.Four));
            cards.Add(new Card(Card.CardSuit.Clubs, Card.CardRank.Ace));
            cards.Add(new Card(Card.CardSuit.Spades, Card.CardRank.Ace));
            cards.Add(new Card(Card.CardSuit.Hearts, Card.CardRank.Ace));
            cards.Add(new Card(Card.CardSuit.Spades, Card.CardRank.King));
            cards.Add(new Card(Card.CardSuit.Hearts, Card.CardRank.Four));
            cards.Add(new Card(Card.CardSuit.Clubs, Card.CardRank.Three));
            cards.Add(new Card(Card.CardSuit.Spades, Card.CardRank.Six));
            //creates new deck passing in (cards) with deck constructor making deep copy (deck) to make safe to use for comparison 
            Deck deck = new Deck(cards);
            //shuffles deck 
            deck.Shuffle(); 
            //local variable storing the number of cards that have changed, beginning at zero
            int changedCards = 0;
                    
            //for each card in list compare to each card in deck if list card not equal to deck card, add one to changed card variable 
            //q1: how to   and q2 how to compare two cards 
            foreach (Card card in cards)
            {
                //draws a card out of local variable deck
                Card? newCard = deck.Draw();
                //checks to see if card is null
                if (newCard == null)
                {
                    throw new NullReferenceException("Card should never be null here."); 
                }
                //Checks if new card and card have same suit AND rank if NOT add 1 to changedCards
                if (newCard.Rank != card.Rank && newCard.Suit != card.Suit)
                {
                    changedCards++;
                }
                
            }
            //Assertion to see if changed cards are at least 80% changed
            Assert.IsTrue(changedCards > 7);

        }
    }
}
//if changed cards equal (assert.istrue)(look at other test) 
//Shuffle function must make sure that the majority (80%) eight out of every 10 cards are different at minimum.
//X-Homework 1: Fix your semicolons. You should get in the habit of making sure you always do your end semicolons with your open (beginning) semicolons. 
//  - Same for parenthesis etc.
//Homework 2: Write a test assert to check that the majority (80%) eight out of every 10 cards really are different.
//  - Avoid floating point numbers.

//Create truth table for 


//Go through the list of cards (List<Card> cards), and compare it to the cards in the deck after they have been shuffled.
//After they have been shuffled, at least some of them should be different. But maybe not all. So your assertions have to be able to handle some not changing.
//There is also a chance that all of the cards are the same, but we will deal with that later. For now just work on this part. 
//Hint: You will need to figure out how to interact with the deck to get the cards out. What public method can you use? Draw
