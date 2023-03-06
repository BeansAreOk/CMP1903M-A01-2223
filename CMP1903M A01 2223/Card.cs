using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    //will set and output the values for each card given
    public class Card
    {
        private string value;
        private string suit;

        //constructor for value and suit strings
        public Card(string cardValue, string cardSuit)
        {
            value = cardValue;
            suit = cardSuit;
        }

        //outputs values of cards given
        public override string ToString()
        {
            return value + " OF " + suit + " ";
        }
    }
}
