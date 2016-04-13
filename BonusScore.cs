using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BonusScore
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 3)
            {
                Console.WriteLine("{0}", number * 10);
            }
            else if (number >= 4 && number <= 6)
            {
                Console.WriteLine("{0}", number * 100);
            }
            else if (number >= 7 && number <= 9)
            {
                Console.WriteLine("{0}", number * 1000);
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
        }
    }

