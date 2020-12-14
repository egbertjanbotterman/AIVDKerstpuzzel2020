using Kerstpuzzel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstpuzzel2020Net
{
    [TestFixture]
    class Opgave19
    {
        [Test]
        public void H4_Veelvoud_Van_Zeven()
        {
            int number = 0;
            List<int> lijstje = new List<int>();
            while (true)
            {
                number = number + 7;

                if (number.ToString().Length > 4)
                {
                    break;
                }
                if (number.ToString().Length < 4)
                {
                    continue;
                }

                if (number.ToString().Contains("0") ||
                    number.ToString().Contains("5") ||
                    number.ToString().Contains("6") ||
                    number.ToString().Contains("7") ||
                    number.ToString().Contains("8") ||
                    number.ToString().Contains("9")
                    )
                { continue; }

                //Want F kan geen 4 
                if (number.ToString().Substring(2).StartsWith("4"))
                {
                    continue;
                }

                //lijstje.Add(number);
                Console.WriteLine(number);

            }

        }

        [Test]
        public void H2_Veelvoud_van_4()
        {
            int number = 0;
            List<int> lijstje = new List<int>();
            while (true)
            {
                number = number + 4;

                if (number.ToString().Length > 3)
                {
                    break;
                }
               
                if (number.ToString().Contains("0") ||
                    number.ToString().Contains("5") ||
                    number.ToString().Contains("6") ||
                    number.ToString().Contains("7") ||
                    number.ToString().Contains("8") ||
                    number.ToString().Contains("9")
                    )
                { continue; }

                //lijstje.Add(number);
                Console.WriteLine(number);

            }
        }

        [Test]
        public void H2_Geen_Veelvoud_van_2_of_3()
        {
            int number = 0;
            List<int> lijstje = new List<int>();
            while (true)
            {
                number = number + 1;

                if (number.ToString().Length > 3)
                {
                    break;
                }

                if (number.ToString().Contains("0") ||
                    number.ToString().Contains("5") ||
                    number.ToString().Contains("6") ||
                    number.ToString().Contains("7") ||
                    number.ToString().Contains("8") ||
                    number.ToString().Contains("9")
                    )
                { continue; }

                if(number%2==0 || number % 3 == 0)
                {
                    continue;
                }
                //lijstje.Add(number);
                Console.WriteLine(number);

            }
        }

        [Test]
        public void V3_Isogram()
        {
            //Getal waarin ieder cijfer maar 1 keer voorkomt
            int number = 1000;
            List<int> lijstje = new List<int>();
            while (true)
            {
                number = number + 1;

                if (number.ToString().Length > 4)
                {
                    break;
                }
                if (number.ToString().Length < 4)
                {
                    continue;
                }

                if (number.ToString().Contains("0") ||
                    number.ToString().Contains("5") ||
                    number.ToString().Contains("6") ||
                    number.ToString().Contains("7") ||
                    number.ToString().Contains("8") ||
                    number.ToString().Contains("9")
                    )
                {
                    continue;
                }

                if (!number.ToString().Contains("1") ||
                    !number.ToString().Contains("2") ||
                    !number.ToString().Contains("3") ||
                    !number.ToString().Contains("4")
                    )
                {
                    continue;
                }
                //Want F kan geen 4 hebben in de sudoku
                if (number.ToString().EndsWith("4"))
                {
                    continue;
                }

                //lijstje.Add(number);
                Console.WriteLine(number);
            }
        }

        [Test]
        public void H3_Priemgetal()
        {
            //Getal waarin ieder cijfer maar 1 keer voorkomt
            int number = 1000;
            List<int> lijstje = new List<int>();
            while (true)
            {
                number = number + 1;

                if (number.ToString().Length > 4)
                {
                    break;
                }
                if (number.ToString().Length < 4)
                {
                    continue;
                }

                if (number.ToString().Contains("0") ||
                    number.ToString().Contains("5") ||
                    number.ToString().Contains("6") ||
                    number.ToString().Contains("7") ||
                    number.ToString().Contains("8") ||
                    number.ToString().Contains("9")
                    )
                {
                    continue;
                }


                if (!Numbers.IsPrime(number))
                {
                    continue;
                }

                //lijstje.Add(number);
                Console.WriteLine(number);
            }
        }


        [Test]
        public void V1_Fibonacci_len_3()
        {
            //Getal waarin ieder cijfer maar 1 keer voorkomt

            //lijstje.Add(number);
            foreach (int number in Numbers.BuildFibonacci(3))
            {
                if (number.ToString().Contains("0") ||
                    number.ToString().Contains("5") ||
                    number.ToString().Contains("6") ||
                    number.ToString().Contains("7") ||
                    number.ToString().Contains("8") ||
                    number.ToString().Contains("9")
                    )
                {
                    continue;
                }
                Console.WriteLine(number);
            }

        }

        [Test]
        public void V1_Delers_Van_11088()
        {
            int number = 0;
            List<int> lijstje = new List<int>();
            while (true)
            {
                number = number + 1;

                if (number.ToString().Length > 3)
                {
                    break;
                }

                if (number.ToString().Contains("0") ||
                    number.ToString().Contains("5") ||
                    number.ToString().Contains("6") ||
                    number.ToString().Contains("7") ||
                    number.ToString().Contains("8") ||
                    number.ToString().Contains("9")
                    )
                {
                    continue;
                }

                if(11088 % number != 0)
                {
                    continue;
                }

                Console.WriteLine(number);
            }
        }

        [Test]
        public void V4_3_Fibonaccis()
        {
            List<int> fibs = Numbers.BuildFibonacci(2);
            List<int> validfibs = new List<int>();

            //lijstje.Add(number);
            foreach (int number in fibs)
            {
                if (number.ToString().Contains("0") ||
                    number.ToString().Contains("5") ||
                    number.ToString().Contains("6") ||
                    number.ToString().Contains("7") ||
                    number.ToString().Contains("8") ||
                    number.ToString().Contains("9") ||
                    validfibs.Contains(number)
                    )
                {
                    continue;
                }
                validfibs.Add(number);
            }
            foreach (int item1 in validfibs)
            {
                foreach (int item2 in validfibs)
                {
                    foreach (int item3 in validfibs)
                    {
                        string newOption = item1.ToString() + item2.ToString() + item3.ToString();
                        if (newOption.Length == 4 &&
                            //Pos 2 en 3 geen 2 of 4
                            !newOption.Substring(1,2).Contains("2") && 
                            !newOption.Substring(1, 2).Contains("4") &&
                            //Pos 1 geen 2 of 3
                            !newOption.Substring(0, 2).Contains("2") &&
                            !newOption.Substring(0, 2).Contains("3")
                            )

                        {
                            Console.WriteLine(newOption);
                        }
                        
                    }
                }
            }

        }


    }
}
