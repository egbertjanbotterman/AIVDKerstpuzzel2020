﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace TravellingSalesmanProg
{
    internal class TravellingSalesmanMapCollection
    {
        public List<State> _stippen = new List<State>();

        public TravellingSalesmanMapCollection()
        {
            InitializeStippenLijst();
        }

        // AIVD Kerstpuzzel teaser 2020
        // Staten in USA, snelste race van Illinois naar Alabama, maar wel alle staten aantikken...? Dit is de route van santa.
        private void InitializeStippenLijst()
        {
            _stippen.Add(new State("Alabama", 890, 614, StateKleur.Blauw));
            _stippen.Add(new State("Texas",577,614, StateKleur.Blauw));
            _stippen.Add(new State("Nebraska",571,323, StateKleur.Blauw));
            _stippen.Add(new State("Arkansas",735,532, StateKleur.Grijs));
            _stippen.Add(new State("SouthCarolina",1036,532, StateKleur.Grijs));
            _stippen.Add(new State("RhodesIsland",1194,252, StateKleur.Rood));
            _stippen.Add(new State("Ohio",951,342, StateKleur.Grijs));
            _stippen.Add(new State("Florida",1036,714, StateKleur.Grijs));
            _stippen.Add(new State("Georgia",972,575, StateKleur.Blauw));
            _stippen.Add(new State("Nevada",149,349, StateKleur.Grijs));
            _stippen.Add(new State("Idaho",1069,391, StateKleur.Rood));
            _stippen.Add(new State("Tennessee",681,159, StateKleur.Grijs));
            _stippen.Add(new State("Oregon",128,212, StateKleur.Grijs));
            _stippen.Add(new State("Virginia",1068,390, StateKleur.Rood));
            _stippen.Add(new State("Minnesota",681,159, StateKleur.Grijs));
            _stippen.Add(new State("Arizona",262,513, StateKleur.Rood));
            _stippen.Add(new State("Illinois",819,387, StateKleur.Blauw));
        }
    }
}