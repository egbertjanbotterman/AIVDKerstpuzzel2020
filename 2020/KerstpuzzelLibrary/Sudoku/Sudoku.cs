using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Kerstpuzzel.Sudoku
{
    public class Sudoku
    {
        private List<int> geldigeNummers;
        private const string _bestandsnaam = "GeldigeSudokuNummers";

        public Sudoku()
        {
            try
            {
                BestandHelper.LoadObject<List<int>>(_bestandsnaam);
            }
            catch { }

            A = new Blok();
            B = new Blok();
            C = new Blok();

            D = new Blok();
            E = new Blok();
            F = new Blok();

            G = new Blok();
            H = new Blok();
            I = new Blok();
        }

        public Sudoku(bool initialize) : this()
        {
            if (initialize)
            {
                Initialize();
            }
        }

        public void Initialize()
        {
            List<int> geldig = new List<int>();
            foreach (Getal getal in Getal.GeldigeNummers)
            {
                geldig.Add(getal.Value);
            }

            BestandHelper.SaveObject(geldig, _bestandsnaam);
        }

        public Blok A;
        public Blok B;
        public Blok C;

        public Blok D;
        public Blok E;
        public Blok F;

        public Blok G;
        public Blok H;
        public Blok I;

        private HashSet<int>[] Rij1 => (A.Rij1.Union(B.Rij1).ToArray()).Union(C.Rij1).ToArray();
        private HashSet<int>[] Rij2 => (A.Rij2.Union(B.Rij2).ToArray()).Union(C.Rij2).ToArray();
        private HashSet<int>[] Rij3 => (A.Rij3.Union(B.Rij3).ToArray()).Union(C.Rij3).ToArray();
        private HashSet<int>[] Rij4 => (D.Rij1.Union(E.Rij1).ToArray()).Union(F.Rij1).ToArray();
        private HashSet<int>[] Rij5 => (D.Rij2.Union(E.Rij2).ToArray()).Union(F.Rij2).ToArray();
        private HashSet<int>[] Rij6 => (D.Rij3.Union(E.Rij3).ToArray()).Union(F.Rij3).ToArray();
        private HashSet<int>[] Rij7 => (G.Rij1.Union(H.Rij1).ToArray()).Union(I.Rij1).ToArray();
        private HashSet<int>[] Rij8 => (G.Rij2.Union(H.Rij2).ToArray()).Union(I.Rij2).ToArray();
        private HashSet<int>[] Rij9 => (G.Rij3.Union(H.Rij3).ToArray()).Union(I.Rij3).ToArray();

        private HashSet<int>[] Kolom1 => (A.Kolom1.Union(D.Kolom1).ToArray()).Union(G.Kolom1).ToArray();
        private HashSet<int>[] Kolom2 => (A.Kolom2.Union(D.Kolom2).ToArray()).Union(G.Kolom2).ToArray();
        private HashSet<int>[] Kolom3 => (A.Kolom3.Union(D.Kolom3).ToArray()).Union(G.Kolom3).ToArray();
        private HashSet<int>[] Kolom4 => (B.Kolom1.Union(E.Kolom1).ToArray()).Union(H.Kolom1).ToArray();
        private HashSet<int>[] Kolom5 => (B.Kolom2.Union(E.Kolom2).ToArray()).Union(H.Kolom2).ToArray();
        private HashSet<int>[] Kolom6 => (B.Kolom3.Union(E.Kolom3).ToArray()).Union(H.Kolom3).ToArray();
        private HashSet<int>[] Kolom7 => (C.Kolom1.Union(F.Kolom1).ToArray()).Union(I.Kolom1).ToArray();
        private HashSet<int>[] Kolom8 => (C.Kolom2.Union(F.Kolom2).ToArray()).Union(I.Kolom2).ToArray();
        private HashSet<int>[] Kolom9 => (D.Kolom3.Union(F.Kolom3).ToArray()).Union(I.Kolom3).ToArray();

        private bool CheckRow1(int row)
        {
            HashSet<int> bekendeWaardes = new HashSet<int>();

            bool changed = false;
            HashSet<int>[] Rij = new HashSet<int>[] { };

            switch (row)
            {
                case 0:
                    Rij = Rij1;
                    break;

                case 1:
                    Rij = Rij2;
                    break;

                case 2:
                    Rij = Rij3;
                    break;

                default:
                    throw new Exception("NOPE");
            }

            foreach (HashSet<int> i in Rij)
            {
                //Als er nog maar 1 mogelijkheid is dan heeft het blok een waarde
                // En dan moet deze mogelijkheid weg bij de rest van het blok
                if (i.Count == 1)
                {
                    bekendeWaardes.Add(i.First());
                }
            }

            // Alle bekende waardes worden gefiltert, behalve uit het blok waar het de enige is
            foreach (int bekendeWaarde in bekendeWaardes)
            {
                A.RemoveOptieUitRij(row, bekendeWaarde);
                B.RemoveOptieUitRij(row, bekendeWaarde);
                C.RemoveOptieUitRij(row, bekendeWaarde);

                changed = true;
            }

            return changed;
        }

        private bool CheckRow2(int row)
        {
            HashSet<int> bekendeWaardes = new HashSet<int>();

            bool changed = false;
            HashSet<int>[] Rij = new HashSet<int>[] { };

            switch (row)
            {
                case 0:
                    Rij = Rij4;
                    break;

                case 1:
                    Rij = Rij5;
                    break;

                case 2:
                    Rij = Rij6;
                    break;

                default:
                    throw new Exception("NOPE");
            }

            foreach (HashSet<int> i in Rij)
            {
                //Als er nog maar 1 mogelijkheid is dan heeft het blok een waarde
                // En dan moet deze mogelijkheid weg bij de rest van het blok
                if (i.Count == 1)
                {
                    bekendeWaardes.Add(i.First());
                }
            }

            // Alle bekende waardes worden gefiltert, behalve uit het blok waar het de enige is
            foreach (int bekendeWaarde in bekendeWaardes)
            {
                D.RemoveOptieUitRij(row, bekendeWaarde);
                E.RemoveOptieUitRij(row, bekendeWaarde);
                F.RemoveOptieUitRij(row, bekendeWaarde);

                changed = true;
            }

            return changed;
        }

        private bool CheckRow3(int row)
        {
            HashSet<int> bekendeWaardes = new HashSet<int>();

            bool changed = false;
            HashSet<int>[] Rij = new HashSet<int>[] { };

            switch (row)
            {
                case 0:
                    Rij = Rij7;
                    break;

                case 1:
                    Rij = Rij8;
                    break;

                case 2:
                    Rij = Rij9;
                    break;

                default:
                    throw new Exception("NOPE");
            }

            foreach (HashSet<int> i in Rij)
            {
                //Als er nog maar 1 mogelijkheid is dan heeft het blok een waarde
                // En dan moet deze mogelijkheid weg bij de rest van het blok
                if (i.Count == 1)
                {
                    bekendeWaardes.Add(i.First());
                }
            }

            // Alle bekende waardes worden gefiltert, behalve uit het blok waar het de enige is
            foreach (int bekendeWaarde in bekendeWaardes)
            {
                G.RemoveOptieUitRij(row, bekendeWaarde);
                H.RemoveOptieUitRij(row, bekendeWaarde);
                I.RemoveOptieUitRij(row, bekendeWaarde);

                changed = true;
            }

            return changed;
        }

        private bool CheckCol1(int col)
        {
            HashSet<int> bekendeWaardes = new HashSet<int>();

            bool changed = false;
            HashSet<int>[] Col = new HashSet<int>[] { };

            switch (col)
            {
                case 0:
                    Col = Kolom1;
                    break;

                case 1:
                    Col = Kolom2;
                    break;

                case 2:
                    Col = Kolom3;
                    break;

                default:
                    throw new Exception("NOPE");
            }

            foreach (HashSet<int> i in Col)
            {
                //Als er nog maar 1 mogelijkheid is dan heeft het blok een waarde
                // En dan moet deze mogelijkheid weg bij de rest van het blok
                if (i.Count == 1)
                {
                    bekendeWaardes.Add(i.First());
                }
            }

            // Alle bekende waardes worden gefiltert, behalve uit het blok waar het de enige is
            foreach (int bekendeWaarde in bekendeWaardes)
            {
                A.RemoveOptieUitKolom(col, bekendeWaarde);
                D.RemoveOptieUitKolom(col, bekendeWaarde);
                G.RemoveOptieUitKolom(col, bekendeWaarde);

                changed = true;
            }

            return changed;
        }

        private bool CheckCol2(int col)
        {
            HashSet<int> bekendeWaardes = new HashSet<int>();

            bool changed = false;
            HashSet<int>[] Col = new HashSet<int>[] { };

            switch (col)
            {
                case 0:
                    Col = Kolom4;
                    break;

                case 1:
                    Col = Kolom5;
                    break;

                case 2:
                    Col = Kolom6;
                    break;

                default:
                    throw new Exception("NOPE");
            }

            foreach (HashSet<int> i in Col)
            {
                //Als er nog maar 1 mogelijkheid is dan heeft het blok een waarde
                // En dan moet deze mogelijkheid weg bij de rest van het blok
                if (i.Count == 1)
                {
                    bekendeWaardes.Add(i.First());
                }
            }

            // Alle bekende waardes worden gefiltert, behalve uit het blok waar het de enige is
            foreach (int bekendeWaarde in bekendeWaardes)
            {
                B.RemoveOptieUitKolom(col, bekendeWaarde);
                E.RemoveOptieUitKolom(col, bekendeWaarde);
                H.RemoveOptieUitKolom(col, bekendeWaarde);

                changed = true;
            }

            return changed;
        }

        private bool CheckCol3(int col)
        {
            HashSet<int> bekendeWaardes = new HashSet<int>();

            bool changed = false;
            HashSet<int>[] Col = new HashSet<int>[] { };

            switch (col)
            {
                case 0:
                    Col = Kolom7;
                    break;

                case 1:
                    Col = Kolom8;
                    break;

                case 2:
                    Col = Kolom9;
                    break;

                default:
                    throw new Exception("NOPE");
            }

            foreach (HashSet<int> i in Col)
            {
                //Als er nog maar 1 mogelijkheid is dan heeft het blok een waarde
                // En dan moet deze mogelijkheid weg bij de rest van het blok
                if (i.Count == 1)
                {
                    bekendeWaardes.Add(i.First());
                }
            }

            // Alle bekende waardes worden gefiltert, behalve uit het blok waar het de enige is
            foreach (int bekendeWaarde in bekendeWaardes)
            {
                C.RemoveOptieUitKolom(col, bekendeWaarde);
                F.RemoveOptieUitKolom(col, bekendeWaarde);
                I.RemoveOptieUitKolom(col, bekendeWaarde);

                changed = true;
            }

            return changed;
        }


        public void Check()
        {
            A.CheckBlock();
            B.CheckBlock();
            C.CheckBlock();
            D.CheckBlock();
            E.CheckBlock();
            F.CheckBlock();
            G.CheckBlock();
            H.CheckBlock();
            I.CheckBlock();

            CheckRow1(0);
            CheckRow1(1);
            CheckRow1(2);
            CheckRow2(0);
            CheckRow2(1);
            CheckRow2(2);
            CheckRow3(0);
            CheckRow3(1);
            CheckRow3(2);

            CheckCol1(0);
            CheckCol1(1);
            CheckCol1(2);
            CheckCol2(0);
            CheckCol2(1);
            CheckCol2(2);
            CheckCol3(0);
            CheckCol3(1);
            CheckCol3(2);
        }

        public override string ToString()
        {
            int repeat = A.RijString(0).Length + B.RijString(0).Length + C.RijString(0).Length;
            return A.RijString(0) + "||" + B.RijString(0) + "||" + C.RijString(0) + "\n\r"
                + A.RijString(1) + "||" + B.RijString(1) + "||" + C.RijString(1) + "\n\r"
            + A.RijString(2) + "||" + B.RijString(2) + "||" + C.RijString(2) + "\n\r"
             + new string('=', repeat) + "\n\r"
            + D.RijString(0) + "||" + E.RijString(0) + "||" + F.RijString(0) + "\n\r"
                    + D.RijString(1) + "||" + E.RijString(1) + "||" + F.RijString(1) + "\n\r"
                    + D.RijString(2) + "||" + E.RijString(2) + "||" + F.RijString(2) + "\n\r"
                + new string('=', repeat) + "\n\r"
                + G.RijString(0) + "||" + H.RijString(0) + "||" + I.RijString(0) + "\n\r"
                + G.RijString(1) + "||" + H.RijString(1) + "||" + I.RijString(1) + "\n\r"
                + G.RijString(2) + "||" + H.RijString(2) + "||" + I.RijString(2) + "\n\r"
                + "\n\r";
        }
    }
}
