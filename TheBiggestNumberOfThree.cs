using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class TheBiggestNumberOfThree
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double maximum = Math.Max(a, Math.Max(b, c));
            Console.WriteLine(maximum);
        }
    }

