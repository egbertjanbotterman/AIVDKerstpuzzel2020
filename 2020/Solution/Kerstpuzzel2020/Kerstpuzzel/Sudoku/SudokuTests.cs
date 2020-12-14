using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace Kerstpuzzel.Sudoku
{
    [TestFixture]
    public class SudokuTests
    {
       
        [Test]
        public void SudToString()
        {
            Sudoku sud = new Sudoku();
            Console.WriteLine(sud);
        }

        [Test]
        public void CalcRow()
        {
            Sudoku sud = new Sudoku();
            sud.A.ZetOpties(0,0,1);
            sud.Check();

            Console.WriteLine(sud);
         //   Assert.IsFalse(sud.B.Rij1[0].Contains(1));

        }
    }
}
