using System;

namespace TravellingSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            TravellingSalesman salesman = new TravellingSalesman();

            for (int i = 0; i < 14; i++)
            {
                var length = State.Afstand(salesman._stippen[2], salesman._stippen[i]);
                Console.WriteLine($"{salesman._stippen[2].Name} - {salesman._stippen[i].Name} = {length}");
            }
        }
    }
}
