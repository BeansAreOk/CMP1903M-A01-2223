using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public void Test()
        {
            Console.WriteLine("How many cards do you want dealt?");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount > 52 || amount < 1)
            {
                throw new Exception("Please choose an appropriate amount of cards to be dealt (1-52).");
            } 

            Console.WriteLine("What shuffling method do you want? (1. Fisher-Yates Shuffle 2. Riffle Shuffle 3. No Shuffle");
            int typeOfShuffle = Convert.ToInt32(Console.ReadLine());
            if (typeOfShuffle > 3 || typeOfShuffle < 1)
            {
                throw new Exception("Please choose an actual shuffling method 1,2 or 3.");
            }

            Pack pack;

            Console.ReadLine();

        }
    }
}
