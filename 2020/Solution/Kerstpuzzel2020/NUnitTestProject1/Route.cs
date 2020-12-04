using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptimalRoute
{
    public class Route : IDisposable
    {
        public Route()
        {
            Legs = new Dictionary<int, Leg>();
        }

        public Dictionary<int, Leg> Legs { get; set; }

        public bool AddLeg(Leg newleg)
        {
            if (Legs.Count > 0 &&
                Legs[Legs.Count].End != newleg.Start ||
                Contains(newleg.End))
            {
                return false;
            }

            Legs.Add(Legs.Count + 1, newleg);
            return true;
        }

        public bool Contains(State state)
        {
            foreach (KeyValuePair<int, Leg> pair in Legs)
            {
                if (pair.Value.Contains(state))
                {
                    return true;
                }
            }
            return false;
        }

        private decimal _length;
        public decimal Length { 
            get 
            { 
                if(_length == 0M)
                {
                   _length= calculateLength();
                    
                }
                return _length;
            }
        }

        private decimal calculateLength()
        {
            {
                decimal length = 0M;
                foreach (KeyValuePair<int, Leg> pair in Legs)
                {
                    length += pair.Value.Length;
                }
                return length;
            }
        }

        public void Dispose()
        {
            Dispose();
        }
    }
}

