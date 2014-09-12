using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Check_ye_rates_again
{
    class Program
    {
        static void Main(string[] args)
        {
            String Doubloons;
            Console.WriteLine("Put in all ye doubloons:");
            Doubloons = Console.ReadLine();
            if (Convert.ToDouble(Doubloons) < 5.65)
            {
                Console.WriteLine("Arrrrrrg, Ye loot per hour be too low matey, Ye ol Governement will repo Ye vessel");
            }
            else if (Convert.ToDouble(Doubloons) > 49.99)
            {
                Console.WriteLine("Yargh? Ye be making too much loot for Ye vessel to carry, the Ol Cracken will sink Ye sorry beards, by day break, arrrrrrg");
            }
        }
    }
}
