using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LootTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            String Hours, HourlyPay;
            Console.Write("Put in the loot ye be stuffing the pockets of your knickers with: ");
            HourlyPay = Console.ReadLine();
            Console.Write("Arg, enter the hours your crew spent swabbing ye vessels poop deck: ");
            Hours = Console.ReadLine();
            double LowTax = .1, HighTax = .12;
            double Pay = Convert.ToDouble(HourlyPay) * Convert.ToDouble(Hours);
            double Low = LowTax * Pay, High = HighTax * Pay;
            if (Pay <= 300.00)
            {
                Console.Write("Arg Matey! Ye need to pillege more villages ye have no loot " + (Pay - Low) .ToString("C"));
            }
            else if (Pay > 300.00)
            {
                Console.Write("Yargh! I be impressed, ye knickers be over floowing with the doubloons " + (Pay - High).ToString("C"));
            }
        }
    }
}
