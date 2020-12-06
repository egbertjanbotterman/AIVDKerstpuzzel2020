using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace TravellingSalesmanProg
{
    public class TravellingSalesMen
    {
        private TravellingSalesmenCollection _salesmenCollections;

        public TravellingSalesMen()
        {
            _salesmenCollections = new TravellingSalesmenCollection();
        }

        public State this[string name] => FindStateByName(name);
        public State this[int nr] => FindStateByNr(nr);

        private State FindStateByNr(int nr)
        {
            return _salesmenCollections._stippen[nr];
        }

        private State FindStateByName(string name)
        {
            return _salesmenCollections._stippen.FirstOrDefault(x => x.Name == name);
        }
    }
}
