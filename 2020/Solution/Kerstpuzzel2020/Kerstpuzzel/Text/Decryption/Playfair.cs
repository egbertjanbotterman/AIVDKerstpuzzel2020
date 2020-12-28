using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstpuzzel.Text.Decryption
{
    public class Playfair
    {
        private static Polybius polybius;

        private string EncryptedText { get; set; }

        public void Decrypt(string encryptedText)
        {
            //ToDo: sanity check: als de text geen even aantal letters heeft dan is het geen playfair
            
            EncryptedText = encryptedText;

            string solution = decryptRecurs("", 0);

        }

        private string decryptRecurs(string solution, int pos)
        {
            if(EncryptedText.Length <= pos)
            {
                return solution;
            }

            string digram = EncryptedText.Substring(pos, 2);



            solution = solution + digram;

            return decryptRecurs(solution, pos + 2);
        }

    }
}
