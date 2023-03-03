using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack : Card
    {
        //List<Card> pack;
        const int NUM_OF_CARDS = 52; //number of all cards 
        private Card[] deck; //array of all playing cards
        private Card[] hand;

        public Pack()
        {
            deck = new Card[NUM_OF_CARDS];
        }

        public Card[] getDeck { get { return deck; } } //get current deck

        //create deck of 52 cards: 13 values each, with 4 suits.
        public void setUpDeck()
        {
            int i = 0;
            foreach (SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach (VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Card { MySuit = s, MyValue = v };
                    i++;
                }
            }
            ShuffleCards();
        }

        public void ShuffleCards() //dummy code that will shuffle cards
        {
            Random rand = new Random();
            Card temp;
            for (int shuffleTimes = 0; shuffleTimes < 1000; shuffleTimes++)
            {
                for (int i = 0; i < NUM_OF_CARDS; i++)
                {
                    //swap the cards 
                    int secondCardIndex = rand.Next(13);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            }
        }

        public void Deal(int amount) 
        {
            hand = new Card[1];
            hand[1] = getDeck[1]; //will deal a single card
        }

        public void DealCards(int amount) 
        {
            hand = new Card[amount];
            for (int i = 0; i < amount; i++)
            {
                hand[amount] = getDeck[amount]; //will deal multiple cards
            }
        }
    }
}