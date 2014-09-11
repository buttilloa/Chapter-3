using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vessel_Dressing
{
    class Program
    {
        static void Main(string[] args)
        {
            String WoodType;
            Console.Write("Enter P for Pine, O for Oak, and M for mahogany");
            WoodType = Console.ReadLine();
            if (WoodType == "P")
            {
                Console.WriteLine("Ye Table Cost 100 Doubloons");
            }
            else if (WoodType == "O")
            {
                Console.WriteLine("Ye Table Cost 225 Doubloons");
            }
            else if (WoodType == "M")
            {
                Console.WriteLine("Ye Table Cost 310 Doubloons");
            }
            else 
            {
                Console.WriteLine("Ye Table Cost 0 Doubloons");
            }
        }
    }
}
