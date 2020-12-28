using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstpuzzel.Text.Decryption
{
    public class Playfair
    {
        private Polybius polybius;

        public Playfair(string key = "", string uncommon = "X")
        {
            polybius = new Polybius(key);
            _uncommon = uncommon;
        }

        private string _uncommon;
        private string EncryptedText { get; set; }

        public string Decrypt(string encryptedText)
        {
            //ToDo: sanity check: als de text geen even aantal letters heeft dan is het geen playfair
            
            EncryptedText = encryptedText;

            string solution = decryptRecurs("", 0);
            return solution;
        }

        public string Sanatize(string unsanatory)
        {
            int index = 0;
            while (index > 0)
            {
                index = unsanatory.IndexOf(_uncommon, index + 1);
                if (index +1 >= unsanatory.Length ||
                    unsanatory.Substring(index - 1, 1) == unsanatory.Substring(index + 1, 1))
                {
                    unsanatory = unsanatory.Remove(index, 1);
                }

                if(unsanatory.IndexOf(_uncommon,index) < 0)
                {
                    break;
                }
            }

            return unsanatory;
        }
        
        private int[] shiftLeft(int[] startPos)
        {
            int newCol = (startPos[1] - 1) < 0 ? 4 : startPos[1] - 1;
            return new[] { startPos[0], newCol };
        }

        private int[] shiftUp(int[] startPos)
        {
            int newRow = (startPos[0] - 1) < 0 ? 4 : startPos[0] - 1;
            return new[] { newRow, startPos[1] };
        }

        private string decryptRecurs(string solution, int pos)
        {
            if(EncryptedText.Length <= pos)
            {
                return solution;
            }

            string digram = EncryptedText.Substring(pos, 2);

            int[] pos1 = polybius.GetCoordinates(digram.Substring(0, 1));
            int[] pos2 = polybius.GetCoordinates(digram.Substring(1, 1));

            string newDigram = "";
            
            //Letters op dezelfde rij
            if(pos1[0] == pos2[0])
            {
                //Letters naar links
                newDigram = polybius.GetValue(shiftLeft(pos1)) + polybius.GetValue(shiftLeft(pos2));
            }
            
            //Letters in dezelfde kolom
            if (pos1[1] == pos2[1])
            {
                //Letters naar boven
                newDigram = polybius.GetValue(shiftUp(pos1)) + polybius.GetValue(shiftUp(pos2));
            }

            if (newDigram == "")
            {
                int[] newPos1 = new int[] { pos1[0], pos2[1] };
                int[] newPos2 = new int[] { pos2[0], pos1[1] };

                newDigram = polybius.GetValue(newPos1) + polybius.GetValue(newPos2);
            }

            solution = solution + newDigram;

            return decryptRecurs(solution, pos + 2);
        }

    }
}
