using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Check_ye_rates
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
                Console.WriteLine("Arrrrrrg, Ye Loot Per Hour Be Too Low Matey");
            }
        }
    }
}
