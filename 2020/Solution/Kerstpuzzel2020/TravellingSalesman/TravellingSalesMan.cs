using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace TravellingSalesmanProg
{
    public class TravellingSalesMan
    {
        private TravellingSalesmanMapCollection _salesmanMapCollection;

        public TravellingSalesMan()
        {
            _salesmanMapCollection = new TravellingSalesmanMapCollection();
        }

        public State this[string name] => FindStateByName(name);
        public State this[int nr] => FindStateByNr(nr);

        private State FindStateByNr(int nr)
        {
            return _salesmanMapCollection._stippen[nr];
        }

        private State FindStateByName(string name)
        {
            return _salesmanMapCollection._stippen.FirstOrDefault(x => x.Name == name);
        }

        public State FindDichtstBijzijnde(State state, State delaatstestate)
        {
            double minlength = double.MaxValue;
            State dichtsbijzijndeState = null;

            foreach (var stip in _salesmanMapCollection._stippen)
            {
                var length = state.AfstandTot(stip);
                if (length > 0 && !stip.Bezocht && length < minlength && stip != delaatstestate)
                {
                    minlength = length;
                    dichtsbijzijndeState = stip;
                }
            }

            return dichtsbijzijndeState;
        }
    }
}
