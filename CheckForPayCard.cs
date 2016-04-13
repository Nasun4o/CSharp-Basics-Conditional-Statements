using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CheckForPayCard
{
    static void Main()
    {
        while (true)
        {
            string card = Console.ReadLine();

            string[] cardFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            bool isCard = false;

            foreach (string face in cardFaces)
            {
                if (String.Equals(card, face))
                {
                    isCard = true;
                }
            }
            Console.WriteLine(isCard ? "Yes" : "No");
        }
    }
}

