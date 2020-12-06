using System;
using System.Collections.Generic;
using System.Text;

namespace TravellingSalesman
{
    /*
        "Alabama",890,614
        "Texas",577,614
        "Nebraska",571,323
        "Arkansas",735,532
        "SouthCarolina",1036,532
        "RhodeIsland",1194,252
        "Ohio",951,342
        "Florida",1036,714
        "Georgia",972,575
        "Nevada",149,349
        "Idaho",1069,391
        "Tennesse",681,159
        "Oregon",128,212
        "Virginia",1068,390
        "Minnesota",681,159
        "Arizona",262,513
        "Illinois",819,387
     */
    public class TravellingSalesman
    {
        public List<State> _stippen = new List<State>();

        public TravellingSalesman()
        {
            InitializeStippenLijst();
        }

        private void InitializeStippenLijst()
        {
            _stippen.Add(new State("Alabama", 890, 614, StaatsKleur.Blauw));
            _stippen.Add(new State("Texas",577,614, StaatsKleur.Blauw));
            _stippen.Add(new State("Nebraska",571,323, StaatsKleur.Blauw));
            _stippen.Add(new State("Arkansas",735,532, StaatsKleur.Grijs));
            _stippen.Add(new State("SouthCarolina",1036,532, StaatsKleur.Grijs));
            _stippen.Add(new State("RhodeIsland",1194,252, StaatsKleur.Rood));
            _stippen.Add(new State("Ohio",951,342, StaatsKleur.Grijs));
            _stippen.Add(new State("Florida",1036,714, StaatsKleur.Grijs));
            _stippen.Add(new State("Georgia",972,575, StaatsKleur.Blauw));
            _stippen.Add(new State("Nevada",149,349, StaatsKleur.Grijs));
            _stippen.Add(new State("Idaho",1069,391, StaatsKleur.Rood));
            _stippen.Add(new State("Tennesse",681,159, StaatsKleur.Grijs));
            _stippen.Add(new State("Oregon",128,212, StaatsKleur.Grijs));
            _stippen.Add(new State("Virginia",1068,390, StaatsKleur.Rood));
            _stippen.Add(new State("Minnesota",681,159, StaatsKleur.Grijs));
            _stippen.Add(new State("Arizona",262,513, StaatsKleur.Rood));
            _stippen.Add(new State("Illinois",819,387, StaatsKleur.Blauw));
        }
    }
}
