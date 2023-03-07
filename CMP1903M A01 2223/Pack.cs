using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Deck
    {
        private Card[] deck;
        private int currentCard;
        private const int NUMBER_OF_CARDS = 52;
        //will be used for shuffle 
        private Random ranNum;

        public Deck()
        {
            //gives values and suits that will be put together in the deck
            string[] values = { "ACE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "JACK", "QUEEN", "KING" };

            string[] suits = { "HEARTS", "CLUBS", "DIAMONDS", "SPADES" };

            deck = new Card[NUMBER_OF_CARDS];
            currentCard = 0;
            ranNum = new Random();
            //used to populate the deck
            for (int count = 0; count < deck.Length; count++)
            {
                //suits and values given to each of the cards
                deck[count] = new Card(values[count % 13], suits[count / 13]);
            }
        }

        public void shuffleCardPack(int typeOfShuffle)
        {
            switch (typeOfShuffle)
            {
                case 1:
                    //Fisher-Yates Shuffle
                    //shuffling algorithm where the unshuffled items are selected, then swapped with the last item in collection that hasn't been selected
                    currentCard = 0;
                    for (int first = 0; first < (deck.Length - 1); first++)
                    {
                        int second = first + ranNum.Next(deck.Length - first);
                        Card temp = deck[second];
                        deck[second] = deck[first];
                        deck[first] = temp;
                    }
                    break;
                case 2:
                    //Riffle shuffle
                    //Most popular way to shuffle and randomise cards, will provide user with an entirely randomised deck of cards if used
                    currentCard = 0;
                    for (int first = 0; first < deck.Length; first++)
                    {
                        int second = ranNum.Next(NUMBER_OF_CARDS);
                        Card temp = deck[first];
                        deck[first] = deck[second];
                        deck[second] = temp;
                    }
                    break;
                case 3:
                    //No shuffle
                    //Pack order doesn't need to be changed
                    break;
                default:
                    //Error handling
                    Console.WriteLine("Incorrect input for shuffle type.");
                    break;

            }
        }

        public Card DealCard()
        {
            //prints the cards and makes sure is within the bounds of the deck array, otherwise return nothing.
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }
    }
}
