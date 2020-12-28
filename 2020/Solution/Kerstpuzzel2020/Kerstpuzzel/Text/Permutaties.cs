using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstpuzzel.Text
{
   public class Permutaties
    {
        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            var temp = a;
            a = b;
            b = temp;
        }

        public static void GetPermutations(char[] list)
        {
            int x = list.Length - 1;
            char[] input = list;
            GetPer(input, 0, x);
        }

        public static void GetPermutations(string list)
        {
            GetPermutations(list.ToCharArray());
        }

       
        public static List<string> Permutations = new List<string>();

        public static void ClearPermutations()
        {
            Permutations.Clear();
        }

        private static void GetPer(char[] list, int recursionDepth, int maxDepth)
        {
            if (recursionDepth == maxDepth)
            {
                Permutations.Add(new string(list));
            }
            else
                for (int i = recursionDepth; i <= maxDepth; i++)
                {
                    Swap(ref list[recursionDepth], ref list[i]);
                    GetPer(list, recursionDepth + 1, maxDepth);
                    Swap(ref list[recursionDepth], ref list[i]);
                }
        }

       
        //static void Main()
        //{
        //    string str = "sagiv";
        //    char[] arr = str.ToCharArray();
        //    GetPer(arr);
        //}
    }
}

