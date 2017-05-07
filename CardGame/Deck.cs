using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Deck
    {
        private Card[] deck;
        private int currentCard; //keep track of where we at inside of deck
        private const int NUMBER_OF_CARDS = 52; //const integer of number of cards
        private Random ranNum;   //for shuffle function

        public Deck()
        {
            string[] faces =
            {
                "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack","Queen", "King"
            };

            string[] suites = {"Heart", "Club", "Spade", "Diamond"};

            deck = new Card[NUMBER_OF_CARDS];
            currentCard = 0;
            ranNum = new Random();
            //populate the deck
            for (int count = 0; count < deck.Length; count++)
                //deck[location]      remainder of count          

                deck[count] = new Card(faces[count%13], suites[count / 13]);
        }


        public void Shuffle()
        {
            currentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                //store the next random number
                int second = ranNum.Next(NUMBER_OF_CARDS);
                //Swap first and second, and so on done to all 52 times
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        public Card DealCard()
        {
            //make sure the curr is within the bound of deck(52)
            if (currentCard < deck.Length)
                return deck[currentCard++];
            else
                return null;
        }

    }
}
