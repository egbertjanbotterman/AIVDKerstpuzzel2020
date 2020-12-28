using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstpuzzel.Text.Decryption
{
    public class Polybius
    {
        public Polybius(string skipChar = "j")
        {
            Populate(skipChar);
        }

        public string[,] Square = new string[5, 5];

        public bool Contains(string value)
        {
            foreach (string item in Square)
            {
                if (item == value)
                {
                    return true;
                }
            }
            return false;
        }

        public void Populate(string skipChar)
        {
            for (int iRow = 0; iRow < 5; iRow++)
            {
                for (int iCol = 0; iCol < 5; iCol++)
                {
                    if (Square[iRow, iCol] == null)
                    {
                        Square[iRow, iCol] = Alfabet.A1B2.First(x => !Contains(x.Key) && !(x.Key == skipChar)).Key;
                    }
                }
            }

        }
    }
}
