using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Testing
    {
        public void Main()
        {
            //Decides what type of shuffle will be used
            Pack deck1 = new Pack();

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
                    Main();
                }
            }
            catch
            {
                Console.WriteLine("Please enter an appropriate integer value for the shuffle type.");
                Main();
            }
            //Decides how many cards are printed
            Console.WriteLine("How many cards would you like to receive? (1-52): ");
            int cards = Convert.ToInt32(Console.ReadLine());

            if (cards <= 52)
            {
                for (int amount = 0; amount < cards; amount++)
                {
                    Console.WriteLine(deck1.DealCard());
                }
            }
            else if (cards == 1)
            {
                Console.WriteLine(deck1.Deal());
            }
            else
            {
                Console.WriteLine("Please enter an appropriate integer for these cards. Returning to start.");
                Main();
            }
            Restart();
            Console.ReadLine();
        }
        public void Restart()
        {
            //Will restart the program after the cards have been dealt if the user wants to interact with the program again.
            Console.WriteLine("Would you like to restart the program? (Y/N): ");
            string restart = Console.ReadLine();
            if (restart == "Y" || restart == "y" || restart == "Yes" || restart == "yes") Main();
            else if (restart == "N" || restart == "n" || restart == "No" || restart == "no")
            {
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("Unexpected input, please try again.");
                Restart();
            }
        }
        }
    }
