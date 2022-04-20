using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Components
{
    public class Card
    {
        public enum CardSuit
        {
            Hearts = 0,
            Clubs = 1,
            Diamonds = 2,
            Spades = 3
        }

        public enum CardRank
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        }

        public CardSuit Suit { get; set; }
        public CardRank Rank { get; set; }

        public Card(CardSuit suit, CardRank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        /*
        public int Score
        {
            get
            {
                if (Value == CardValue.King
                    || Value == CardValue.Queen
                    || Value == CardValue.Jack)
                {
                    return 10;
                }
                if (Value == CardValue.Ace)
                {
                    return 11;
                }
                else
                {
                    return (int)Value;
                }
            }

        }*/


        //Assignment:

        //You will need to create a constructor and properties for the Card class.
        //You will have to decide whether to make the properties readonly or read/write.
        //Use encapsulation to protect your card data.
        //Hint: You can set values in the constructor.

        //Suit
        //Value
      

    }
}
