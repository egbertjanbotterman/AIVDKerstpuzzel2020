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
    }
}
