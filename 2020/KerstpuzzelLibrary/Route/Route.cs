using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kerstpuzzel.Route
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

        public bool Contains(Node node)
        {
            foreach (KeyValuePair<int, Leg> pair in Legs)
            {
                if (pair.Value.Contains(node))
                {
                    return true;
                }
            }
            return false;
        }

        private double _length;
        public double Length
        {
            get
            {
                if (_length == 0)
                {
                    _length = calculateLength();

                }
                return _length;
            }
        }

        private double calculateLength()
        {
            {
                double length = 0;
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

