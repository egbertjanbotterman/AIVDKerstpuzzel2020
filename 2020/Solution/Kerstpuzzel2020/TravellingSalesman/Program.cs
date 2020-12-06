using System;
using System.Runtime.InteropServices;

namespace TravellingSalesmanProg
{
    class Program
    {
        static void Main(string[] args)
        {
            var travellingSalesmen = new TravellingSalesMen();

            for (int i = 0; i < 14; i++)
            {
                var length = State.Afstand(travellingSalesmen[2], travellingSalesmen[i]);
                Console.WriteLine($"{travellingSalesmen[2].Name} - {travellingSalesmen[i].Name} = {length}");
            }

            Console.WriteLine("****");


            var texas = travellingSalesmen["Texas"];
            Console.WriteLine($"{texas.Name}");
            Console.WriteLine($"{texas.Name} - Nevada = {texas.AfstandTot(travellingSalesmen["Nevada"])}");
        }
    }
}
