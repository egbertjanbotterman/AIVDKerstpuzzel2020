using System;
using System.Collections.Generic;

namespace Kerstpuzzel.Sudoku
{
    public class Getal
    {
        private bool baggerBinnen = false;
        public Getal(int getal)
        {
            if (getal < 100 || getal > 999)
            {
                baggerBinnen = true;
            }
            else
            {
                EersteCijfer = Int32.Parse(getal.ToString().Substring(0, 1));
                TweedeCijfer = Int32.Parse(getal.ToString().Substring(1, 1));
                DerdeCijfer = Int32.Parse(getal.ToString().Substring(2, 1));
            }
        }

        public int Value => EersteCijfer * 100 + TweedeCijfer * 10 + DerdeCijfer;
        public Getal(int A, int B, int C)
        {
            EersteCijfer = A;
            TweedeCijfer = B;
            DerdeCijfer = C;
        }

        public bool Valid => !baggerBinnen && 
                             EersteCijfer != 0 && TweedeCijfer !=0 && DerdeCijfer !=0 &&
                             EersteCijfer != TweedeCijfer && EersteCijfer != DerdeCijfer && TweedeCijfer != DerdeCijfer;

        public int EersteCijfer { get; set; }
        public int TweedeCijfer { get; set; }
        public int DerdeCijfer { get; set; }

        public bool Bevat(int getal)
        {
            return EersteCijfer == getal || TweedeCijfer == getal || DerdeCijfer ==getal;
        }
        
        public static List<Getal> GeldigeNummers
        {
            get
            {
                List<Getal> lijst = new List<Getal>();
                for (int i = 123; i < 987; i++)
                {
                    Getal num = new Getal(i);
                    if (num.Valid)
                    {
                        lijst.Add(num);
                    }
                }

                return lijst;
            }
        }

        public static bool operator >(Getal numA, Getal numB)
        {
            return numA.Value > numB.Value;
        }

        public static bool operator <(Getal numA, Getal numB)
        {
            return numA.Value < numB.Value;
        }

        public static bool operator ==(Getal numA, Getal numB)
        {
            return numA.Value == numB.Value;
        }

        public static bool operator !=(Getal numA, Getal numB)
        {
            return numA.Value != numB.Value;
        }

        public static int operator *(Getal numA, int numB)
        {
            return numA.Value * numB;
        }

        public static int operator +(Getal numA, int numB)
        {
            return numA.Value + numB;
        }

        public static int operator +(Getal numA, Getal numB)
        {
            return numA.Value + numB.Value;
        }

        public static int operator +(int numA, Getal numB)
        {
            return numA + numB.Value;
        }

        public static int operator *(int numA, Getal numB)
        {
            return numA * numB.Value;
        }
    }
}
