using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstpuzzel
{
    public static class Numbers
    {
        public static bool IsPrime(int number)
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

        public static bool IsFibonacci(int number)
        {
            List<int> fiblist = BuildFibonacci(number.ToString().Length);
            return fiblist.Contains(number);
        }

        public static List<int> BuildFibonacci(int len)
        {
            return Fibonacci_Rec_Temp(0, 1, len, new List<int>());
        }
        private static List<int> Fibonacci_Rec_Temp(int a, int b, int len, List<int> list )
        {
            if (a.ToString().Length <= len)
            {
                list.Add(a);
                return Fibonacci_Rec_Temp(b, a + b, len, list);
            }
            return list;
        }
    }
}
