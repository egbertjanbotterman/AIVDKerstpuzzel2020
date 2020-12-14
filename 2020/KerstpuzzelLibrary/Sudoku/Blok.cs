using System.Collections.Generic;
using System.Linq;

namespace Kerstpuzzel.Sudoku
{
    public class Blok
    {
        private readonly HashSet<int>[,] grid;

        public Blok()
        {
            grid = new HashSet<int>[3, 3];

            Rij1 = new HashSet<int>[3];
            Rij2 = new HashSet<int>[3];
            Rij3 = new HashSet<int>[3];

            Kolom1 = new HashSet<int>[3];
            Kolom2 = new HashSet<int>[3];
            Kolom3 = new HashSet<int>[3];

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    grid[i,j] = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                }
            }
        }

        public HashSet<int>[] Rij1
        {
            get => new[] { grid[0, 0], grid[1, 0], grid[2, 0] };
            set
            {
                grid[0, 0] = value[0];
                grid[1, 0] = value[1];
                grid[2, 0] = value[2];
            }
        }

        public HashSet<int>[] Rij2
        {
            get => new[] { grid[0, 1], grid[1, 1], grid[2, 1] };
            set
            {
                grid[0, 1] = value[0];
                grid[1, 1] = value[1];
                grid[2, 1] = value[2];
            }
        }

        public HashSet<int>[] Rij3
        {
            get => new[] { grid[0, 2], grid[1, 2], grid[2, 2] };
            set
            {
                grid[0, 0] = value[0];
                grid[1, 0] = value[1];
                grid[2, 0] = value[2];
            }
        }

        public HashSet<int>[] Kolom1
        {
            get => new[] { grid[0, 0], grid[0, 1], grid[0, 1] };
            set
            {
                grid[0, 0] = value[0];
                grid[0, 1] = value[1];
                grid[0, 2] = value[2];
            }
        }

        public HashSet<int>[] Kolom2
        {
            get => new[] { grid[1, 0], grid[1, 1], grid[1, 1] };
            set
             {
                grid[1, 0] = value[0];
                grid[1, 1] = value[1];
                grid[1, 2] = value[2];
            }
        }

        public HashSet<int>[] Kolom3
        {
            get => new[] { grid[2, 0], grid[2, 1], grid[2, 1] };
            set
            {
                grid[2, 0] = value[0];
                grid[2, 1] = value[1];
                grid[2, 2] = value[2];
            }
        }

        public HashSet<int> Possibles;

        public bool CheckBlock()
        {
            HashSet<int> bekendeWaardes = new HashSet<int>();
            bool changed = false;
            foreach (HashSet<int> i in grid)
            {
                //Als er nog maar 1 mogelijkheid is dan heeft het blok een waarde
                // En dan moet deze mogelijkheid weg bij de rest van het blok
                if (i.Count == 1)
                {
                    bekendeWaardes.Add(i.First());
                }
            }

            foreach (HashSet<int> i in grid)
            {
                // Alle bekende waardes worden gefiltert, behalve uit het blok waar het de enige is
                foreach (int bekendeWaarde in bekendeWaardes)
                {
                    if (!(i.Count == 1 && i.First() == bekendeWaarde))
                    {
                        i.Remove(bekendeWaarde);
                        changed = true;
                    }
                }
            }
            
            return changed;
        }

        /// <summary>
        /// Rij en Kolom zijn 0-based integers
        /// </summary>
        /// <param name="Rij"></param>
        /// <param name="Kolom"></param>
        /// <param name="opties"></param>
        public void ZetOpties(int Rij, int Kolom, HashSet<int> opties)
        {
            grid[Rij, Kolom] = opties;
        }

        public void ZetOpties(int Rij, int Kolom, int optie)
        {
            grid[Rij, Kolom] = new HashSet<int>(){optie};
        }

        public string RijString(int row)
        {
            return string.Join("", grid[row,0]) + "|" + string.Join("", grid[row, 1]) + "|" + string.Join("", grid[row, 2]);
        }

        public void RemoveOptieUitRij(int row, int teVerwijderenOptie)
        {
            safeRemove(row, 0, teVerwijderenOptie);
            safeRemove(row, 1, teVerwijderenOptie);
            safeRemove(row, 2, teVerwijderenOptie);
        }

        private void safeRemove(int row, int col, int optie)
        {
            if (grid[row, col].Count > 1)
            {
                grid[row, col].Remove(optie);
            }
        }

        public void RemoveOptieUitKolom(int col, int teVerwijderenOptie)
        {
            safeRemove(0, col, teVerwijderenOptie);
            safeRemove(1, col, teVerwijderenOptie);
            safeRemove(2, col, teVerwijderenOptie);
        }
    }
}
