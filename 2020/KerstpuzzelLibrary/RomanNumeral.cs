using System;
using System.Linq;

namespace KerstpuzzelLibrary
{
    public class RomanNumeral
    {
        public RomanNumeral(string numeral)
        {
            Numeral = numeral;
            Value = FromRoman(numeral);
            IsOdd = Value % 2 != 0;
            IsPrime = isPrime(Value);
            Pos1 = Convert.ToChar(Numeral.Substring(0, 1));
            Pos2 = Convert.ToChar(Numeral.Substring(1, 1));
            Pos3 = Convert.ToChar(Numeral.Substring(2, 1));
            Pos4 = Convert.ToChar(Numeral.Substring(3, 1));
            Pos5 = Convert.ToChar(Numeral.Substring(4, 1));
        }

        public string Numeral { get; private set; }
        public int Value { get; private set; }

        public bool IsOdd { get; private set; }
        public bool IsPrime { get; private set; }

        public char Pos1 { get; private set; }
        public char Pos2 { get; private set; }
        public char Pos3 { get; private set; }
        public char Pos4 { get; private set; }
        public char Pos5 { get; private set; }


        public static bool IsValid(string num)
        {
            //De 'halve' symbolen V, L en D (5, 50 en 500) komen maximaal één keer in een getal voor.
            char V = 'V';
            char I = 'I';
            if (num.Count(v => v == V) > 1 ||
                num.Count(l => l == 'L') > 1 ||
                num.Count(d => d == 'D') > 1)
            {
                return false;
            }

            //  return true;
            //Hieronder de moderne regels

            // Hooguit drie keer hetzelfde symbool achter elkaar, dus niet VIIII maar IX.
            int achterElkaar = 0;
            char current = 'q';
            int aantalafgetrokken = 0;
            bool resetAchterelkaar = false;

            foreach (var t in num)
            {
                if (t == current)
                {
                    achterElkaar++;
                    if (achterElkaar > 3)
                    {
                        return false;
                    }
                }
                else
                {
                    resetAchterelkaar = true;
                }

                //aftrekken: current M MCIX als waarde van current < dan waarde van t dan wordt ie afgetrokken

                if (current != 'q' && FromRoman(current) < FromRoman(t))
                {
                    if (current == 'V' || current == 'L' || current == 'D') //De symbolen V, L en D worden niet gebruikt om afgetrokken te worden, dus niet VL maar XLV en niet VC maar XCV.
                    {
                        return false;
                    }

                    //Men trekt een symbool af van een symbool waarvan de waarde vijf of tien keer zo hoog is, dus niet IL maar XLIX en (ook vanwege deze regel) niet VC maar XCV.
                    if (FromRoman(current) * 5 != FromRoman(t) && FromRoman(current) * 10 != FromRoman(t))
                    {
                        return false;
                    }

                    //Van een symbool wordt hooguit één symbool afgetrokken, dus niet IIX maar VIII.
                    if (achterElkaar > 1)
                    {
                        return false;
                    }

                    if (aantalafgetrokken > 0)
                    {
                        return false;
                    }

                    aantalafgetrokken++;
                }
                else
                {
                    aantalafgetrokken = 0;
                }

                if (resetAchterelkaar)
                {
                    achterElkaar = 1;
                    resetAchterelkaar = false;
                }
                current = t;

            }

            // De notaties van de duizendtallen, de honderdtallen, de tientallen en de eenheden worden achter elkaar gezet, bijvoorbeeld:
            //45 is 40 plus 5, dit wordt XL en V, dus XLV;
            //95 is 90 plus 5, dit wordt XC en V, dus XCV;
            //49 is 40 plus 9, dit wordt XL en IX, dus XLIX;
            //126 is 100 plus 20 plus 6, dit worden C, XX en VI, dus CXXVI.




            return true;
        }

        private static bool isPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
        private static int romanValue(int index)
        {
            int basefactor = index % 2 * 4 + 1; // either 1 or 5...
            // ...multiplied with the exponentation of 10, if the literal is `x` or higher
            return index > 1 ? (int)(basefactor * Math.Pow(10.0, index / 2)) : basefactor;
        }


        private static int FromRoman(char charact)
        {
            return FromRoman(Convert.ToString(charact));
        }

        private static int FromRoman(string roman)
        {
            roman = roman.ToLower();
            string literals = "mdclxvi";
            int value = 0, index = 0;
            foreach (char literal in literals)
            {
                value = romanValue(literals.Length - literals.IndexOf(literal) - 1);
                index = roman.IndexOf(literal);
                if (index > -1)
                    return FromRoman(roman.Substring(index + 1)) + (index > 0 ? value - FromRoman(roman.Substring(0, index)) : value);
            }
            return 0;
        }

    }
}