using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace TravellingSalesmanProg
{
    class Program
    {
        static void Main(string[] args)
        {
            var travellingSalesMan = new TravellingSalesMan();

            var startstate = travellingSalesMan["Illinois"];
            var endstate = travellingSalesMan["Alabama"];

            string stringTotal = "";

            while (startstate != null)
            {
                stringTotal += startstate.Name[3 - (int)startstate.Kleur];
                Console.WriteLine($"{startstate.Name}");
                startstate.Bezocht = true;
                startstate = travellingSalesMan.FindDichtstBijzijnde(startstate, endstate);
            }
            Console.WriteLine($"{endstate.Name}");
            Console.WriteLine($"{stringTotal}");
        }
    }
}
