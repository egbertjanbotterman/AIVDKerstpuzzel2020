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

        public static string DecimalToDifferentBase(long decimalNumber, long radix)
        {
            const int BitsInLong = 64;
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz+/";

            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " +
                    Digits.Length.ToString());

            if (decimalNumber == 0)
                return "0";

            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(decimalNumber);
            char[] charArray = new char[BitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % radix);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / radix;
            }

            string result = new String(charArray, index + 1, BitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result;
        }
    }
}
