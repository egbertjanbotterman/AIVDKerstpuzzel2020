using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstpuzzel.Text
{
    public static class Text
    {

        private static string _vowels = "aeiouAEIOU";
        public static bool IsVowel(string c)
        {
            return _vowels.Contains(c);
        }

        public static bool ContainsVowel(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (IsVowel(text.Substring(i, 1)))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Checks if the text starts with invalid double consonants according to dutch language rules
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool ValidDoubleConsonant(string text)
        {
            string eersteLetter = text.Substring(0, 1);
            string tweedeLetter = text.Substring(1, 1);

            //Geen medeklinkers, dan is het wel goed
            if (IsVowel(eersteLetter) || IsVowel(tweedeLetter))
            {
                return true;
            }

            //2 dezelfde medeklinkers is altijd fout
            if (eersteLetter == tweedeLetter)
            {
                return false;
            }

            if (eersteLetter == "q"
                || tweedeLetter == "b"
                || tweedeLetter == "g"
                || tweedeLetter == "p"
                || tweedeLetter == "v"
                || tweedeLetter == "x"
                || tweedeLetter == "z"
                || (eersteLetter == "b" && !"lry".Contains(tweedeLetter))
                || (eersteLetter == "c" && !"hlry".Contains(tweedeLetter))
                || (eersteLetter == "d" && !"ry".Contains(tweedeLetter))
                || (eersteLetter == "f" && !"jlnry".Contains(tweedeLetter))
                || (eersteLetter == "g" && !"hlnry".Contains(tweedeLetter))
                || ("hjlmnx".Contains(eersteLetter) && !"y".Contains(tweedeLetter))
                || (eersteLetter == "k" && !"lnrwy".Contains(tweedeLetter))
                || (eersteLetter == "p" && !"hlnrsty".Contains(tweedeLetter))

                || (eersteLetter == "r" && !"hy".Contains(tweedeLetter))
                || (eersteLetter == "p" && !"hlnrsty".Contains(tweedeLetter))
                || (eersteLetter == "s" && !"cfhjklmnrtwy".Contains(tweedeLetter))
                || (eersteLetter == "t" && !"hrswy".Contains(tweedeLetter))

                || (eersteLetter == "v" && !"lry".Contains(tweedeLetter))
                || (eersteLetter == "w" && !"hry".Contains(tweedeLetter))
                || (eersteLetter == "y" && !"rsdfhklmnt".Contains(tweedeLetter))
                || (eersteLetter == "z" && !"hlrwy".Contains(tweedeLetter))

                )
            {
                return false;
            }

            return ValidEnding(text);
        }

        private static bool ValidEnding(string text)
        {
            string voorlaatsteLetter = text.Substring(text.Length - 2, 1).ToLower();
            string laatsteLetter = text.Substring(text.Length - 1, 1).ToLower();


            //Nooit 2 gelijke medeklinkers aan het eind van een NL woord
            //Letop: leenworden zoals jazz en stress kunnen natuurlijk wel, maar worden nu ook afgekeurd
            return (voorlaatsteLetter != laatsteLetter ||
                    IsVowel(voorlaatsteLetter)) &&
                    (laatsteLetter != "w" ||
                    voorlaatsteLetter == "u")
                    ;
        }

        private static bool ValidDoubleVowel(string text)
        {
            Char a = 'a';
            Char e = 'e';
            Char i = 'i';
            Char o = 'o';
            Char u = 'u';

            return !text.Contains(new string(a, 3))
                   && !text.Contains(new string(e, 3))
                   && !text.Contains(new string(i, 3))
                 && !text.Contains(new string(o, 3))
                   && !text.Contains(new string(u, 3));
        }

        public static bool CouldBeADutchWord(string text)
        {
            // Voor w aan het eind van een woord komt altijd een u

            return ContainsConsonant(text) &&
                   ContainsVowel(text) &&
                   ValidDoubleConsonant(text)
                   //Een v en z komen nooit aan het eind van een woord
                   && !text.ToLower().EndsWith("v")
                   && !text.ToLower().EndsWith("z")
                   //Geen –h aan het eind van een woord
                   && !text.ToLower().EndsWith("h")
                   //Geen j aan het eind van een woord
                   && !text.ToLower().EndsWith("j")
                   ;
        }

        public static bool ContainsConsonant(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!IsVowel(text.Substring(i, 1)))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ContainsKeyWords(string text)
        {
            string upper = text.ToUpper();


            return upper.Contains("DE")
                || upper.Contains("HET")
                || upper.Contains("EEN")
|| upper.Contains("DAT")
|| upper.Contains("DIE")
|| upper.Contains("DIE")
|| upper.Contains("EN")
|| upper.Contains("HEBBEN")
|| upper.Contains("IK")
|| upper.Contains("IN")
|| upper.Contains("IS")
|| upper.Contains("JA")
|| upper.Contains("JE")
|| upper.Contains("MAAR")
|| upper.Contains("MET")
|| upper.Contains("NIET")
|| upper.Contains("OP")
|| upper.Contains("TE")
|| upper.Contains("UH")
|| upper.Contains("VAN")
|| upper.Contains("VOOR")
|| upper.Contains("WORDEN")
|| upper.Contains("ZIJN");

        }
    }
}
