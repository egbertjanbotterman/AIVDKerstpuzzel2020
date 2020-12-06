using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace TravellingSalesman
{
    // Een stip op de kaart.
    public class State
    {
        public string Name { get; set; }
        public Vector Locatie { get; set; }
        public StaatsKleur Kleur { get; set; }
        public bool Bezocht { get; set; } = false;

        public State(string name, int x, int y, StaatsKleur kleur)
        {
            Name = name;
            Locatie = new Vector( {X = x, Y = y};
            Kleur = kleur;
        }
    }
}
