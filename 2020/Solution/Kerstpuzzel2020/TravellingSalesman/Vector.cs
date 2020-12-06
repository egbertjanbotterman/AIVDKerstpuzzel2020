using System;
using System.Collections.Generic;
using System.Text;

namespace TravellingSalesmanProg
{
    public class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static double Afstand(Vector src, Vector dst)
        {
            var deltaX = dst.X - src.X;
            var deltaY = dst.Y - src.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
