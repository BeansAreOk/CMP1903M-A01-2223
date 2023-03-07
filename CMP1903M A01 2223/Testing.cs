using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Testing
    {
        public static void Main()
        {
            //Decides what type of shuffle will be used
            Deck deck1 = new Deck();

            try
            {
                Console.WriteLine("What shuffling method do you want? (1. Fisher-Yates Shuffle 2. Riffle Shuffle 3. No Shuffle): ");
                int typeOfShuffle = Convert.ToInt32(Console.ReadLine());
                if (typeOfShuffle == 1 || typeOfShuffle == 2 || typeOfShuffle == 3)
                {
                    deck1.shuffleCardPack(typeOfShuffle);
                }
                else
                {
                    Console.WriteLine("Please enter an appropriate integer value for the shuffle type.");
                    Testing.Main();
                }
            }
            catch
            {
                Console.WriteLine("Please enter an appropriate integer value for the shuffle type.");
                Testing.Main();
            }
            //Decides how many cards are printed
            try
            {
                Console.WriteLine("How many cards would you like to receive? (1-52): ");
                int cards = Convert.ToInt32(Console.ReadLine());

                if (cards <= 1 || cards <= 52)
                {
                    for (int amount = 0; amount < cards; amount++)
                    {
                        Console.Write(deck1.DealCard());
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an appropriate integer for these cards. Returning to start.");
                    Testing.Main();

                }
            }
            catch
            {
                Console.WriteLine("Please enter an appropriate integer for these cards. Returning to start.");
                Testing.Main();
            }
            Console.ReadLine();
        }
    }
}
