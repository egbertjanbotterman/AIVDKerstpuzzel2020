using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace TravellingSalesman
{
    // Een stip op de kaart.
    public class State
    {
        public string Name { get; set; }
        public Vector Locatie { get; set; }
        public StateKleur Kleur { get; set; }
        public bool Bezocht { get; set; } = false;      

        public State(string name, int x, int y, StateKleur kleur)
        {
            Name = name;
            Locatie = new Vector {X = x, Y = y};
            Kleur = kleur;
        }

        public static double Afstand(State src, State dst)
        {
            return Vector.Afstand(src.Locatie, dst.Locatie);
        }
    }
}
