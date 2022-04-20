using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Components
{
    public class Deck
    {
        private List<Card> _cards = new List<Card>();

        public Deck()
        {
            GenerateDeck();
        }

        //overloaded constructor using generic type of list 
        //populating this deck of cards from a list called cardsToCopy using a deep copy
        public Deck(List<Card> cardsToCopy)
        {
            foreach (Card card in cardsToCopy)
            {
                //Make a copy of the card.
                Card cardCopy = new Card(card.Suit, card.Rank);

                _cards.Add(cardCopy);
            }
        }

        public int NumberOfCardsInDeck { get { return _cards.Count; } }

        private void GenerateDeck()
        {
            foreach (int suitValue in Enum.GetValues(typeof(Card.CardSuit)))
            {
                foreach (int rankValue in Enum.GetValues(typeof(Card.CardRank)))
                {
                    Card.CardSuit suit = (Card.CardSuit)suitValue;
                    Card.CardRank rank = (Card.CardRank)rankValue;
                    Card card = new Card(suit, rank);

                    _cards.Add(card);
                }
            }
        }
        //Make a deep copy of the cards list.
        //Store the cloned cards in our _cards.
        //create deep copy (deck) to test
        private void CreateDeepCopy(List<Card> cardsToCopy)
        {
            List<Card> copy = new List<Card>();
            foreach (Card card in cardsToCopy)
            {
                //Make a copy of the card.
                Card cardCopy = new Card(card.Suit, card.Rank);

                _cards.Add(cardCopy);
            }
        }


        //Assignment: 

        //You will need to implement the functions below.
        //You will also need to create a constructor. The constructor is the code
        //   that runs whenever the class is instantiated into an object.
        //In this class, the constructor will need to handle creating the deck.
        //I will let you decide how best to implement that.

        //Also: You do not have to implement things exactly this way.
        //But you will need at least a way to draw cards, bare minimum.
        //And you cannot draw the same card twice.

        //Draw a card from the top of the deck.
        //Remove it from the deck.
        public Card? Draw()
        {
            if (_cards.Count == 0) 
                return null;

            Card draw = _cards[0];
            _cards.RemoveAt(0);

            return draw;
        }

        //Needs to shuffle at least 80% of the cards. 
        //Plain real world algorithm
        //Steps to shuffle: 1) put cards on table 2) mix cards around 3) put cards back in deck.
        
        //Refactor getting close to codeable 
        //1) create list of cards 2) randomize by swapping card with random card in index

        //Refactor Algorithm into codable state
        //1) generate list of cards with GenerateDeck() stored in _cards
        //2) For each(card in _cards) swap with swap function at random index

        public void Shuffle()
        {
            //1) generate list of cards with GenerateDeck() stored in _cards
            GenerateDeck();

            //2)???
            //create variable to store new list to compare to
            List<Card> copyToCompareCards = new List<Card>();
            //Homework: Figure out where we're making a deep copy and where we're storing it. 
         

            //3) For(card in _cards) swap with swap function at random index

            //4) compare new list to _cards list counting cards that did not change
        }



        //Will look something like:
        /*private static Random rnd = new Random();

        static void Main(string[] args)
        {
            var numbers = new List<int>(Enumerable.Range(1, 13));
            var shuffledList = numbers.OrderBy(a => rnd.Next()).ToList();

            Console.WriteLine(string.Join(",  ", shuffledList));
        }
        */

    }
}
