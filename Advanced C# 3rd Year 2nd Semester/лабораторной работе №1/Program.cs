using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int chairs, guests, j, c = 1;
            Console.Write("Enter number of guests");
            chairs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of chairs");
            guests = Convert.ToInt32(Console.ReadLine());
            int comb1 = guests - chairs + c;
            int comb2 = guests - chairs + c;
            for (int i = 1; i < chairs; i++)
            {
                j = comb2 * (comb1 + i);
                comb2 = j;
            }
            Console.Write(Convert.ToString(comb2));
            Console.ReadLine();

        }
    }
}
