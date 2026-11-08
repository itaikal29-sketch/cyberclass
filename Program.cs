using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int best = 0;
            double highest = -1;
            double slow = 0;
            for (int i = 0; i <15; i++)
            {
                double sweets = 0;
                for (int j = 0; j < 30; j++)
                {
                    Console.WriteLine("enter sweets");
                    sweets = double.Parse(Console.ReadLine()) + sweets;
                }
                double avrege = sweets / 30;
                if (avrege > highest)
                {
                    highest = avrege;
                    best = i;

                }
                if (avrege < 100)
                {
                    slow++;

                }

            }
            Console.WriteLine("best machine is "+best);
            Console.WriteLine("the number of machines who are under preforming 100 is "+slow);





        }
    }
}
