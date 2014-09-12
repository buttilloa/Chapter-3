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
            Console.Write("Enter P for Pine, O for Oak, and M for mahog-arggg-any");
            WoodType = Console.ReadLine();
            if (WoodType == "P")
            {
                Console.WriteLine("Ye Table Cost 100 doubloons");
            }
            else if (WoodType == "O")
            {
                Console.WriteLine("Ye nice wooden table will make a good peg leg one day, it will cost ye 225 doubloons");
            }
            else if (WoodType == "M")
            {
                Console.WriteLine("Ye stand where ye rest your mug Cost 310 doubloons");
            }
            else 
            {
                Console.WriteLine("Ye wooden resting stand cost 0 doubloons");
            }
        }
    }
}
