using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                
                case 1:
                    {
                        int userInput = int.Parse(Console.ReadLine());
                        Console.WriteLine(userInput + 1);
                        break;
                    }
                case 2:
                    {
                        double userInput = double.Parse(Console.ReadLine());
                        Console.WriteLine(userInput + 1);
                        break;
                    }
                case 3:
                    {
                        string userInput = Console.ReadLine();
                        Console.WriteLine("{0}*", userInput);
                        break;
                    }
            }
            Console.WriteLine();
        }
    }
}
