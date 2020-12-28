using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstpuzzel.Text.Decryption
{
    public class Polybius
    {
        public Polybius(string key , string skipChar = "J")
        {
            _skipChar = skipChar;
            Populate(key);
        }

        private string _skipChar;

        private string getEquivalent(string letter)
        {
            switch (letter)
            {
                case "J": return "I";                
                default: return "";
            }
        }

        public string[,] Square = new string[5, 5];

        public bool Contains(string value)
        {
            foreach (string item in Square)
            {
                if (item == value.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }

        public void Populate(string key)
        {
            for (int iRow = 0; iRow < 5; iRow++)
            {
                for (int iCol = 0; iCol < 5; iCol++)
                {
                    if (Square[iRow, iCol] == null)
                    {
                        if (key != "")
                        {
                            Square[iRow, iCol] = key.Substring(0, 1);
                            key = key.Substring(1);
                        }
                        else
                        {
                            Square[iRow, iCol] = Alfabet.A1B2.First(x => !Contains(x.Key) && !(x.Key.ToUpper() == _skipChar.ToUpper())).Key.ToUpper();
                        }

                    }
                }
            }

        }

        internal int[] GetCoordinates(string v)
        {
            string value = v.ToUpper();
            //Als gevraagd wordt naar het skipChar, dan het equivalent gebruiken
            if(value == _skipChar)
            {
                value = getEquivalent(value);
            }


            for (int iRow = 0; iRow < 5; iRow++)
            {
                for (int iCol = 0; iCol < 5; iCol++)
                {
                    if (Square[iRow, iCol] == value)
                    {
                       return new int[] { iRow, iCol };
                    }
                }
            }

            throw new Exception("Polybius bevat de gevraagde waarde heul nie man!");
        }

        internal string GetValue(int[] pos)
        {
            return Square[pos[0], pos[1]];
        }
    }
}
