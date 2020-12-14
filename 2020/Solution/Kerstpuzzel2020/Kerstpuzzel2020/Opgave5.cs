using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kerstpuzzel;

namespace Kerstpuzzel2020Net
{
    [TestFixture]
    public class Opgave5
    {
        [Test]
        public void tellen()
        {
            //2*6==84
            //long i =(long) 2.5;
            //string two = Numbers.DecimalToDifferentBase(2, i);
            //string six = Numbers.DecimalToDifferentBase(6, i);
            //string twelve = Numbers.DecimalToDifferentBase(12, i);
            //Console.WriteLine("Base: " + i + " :" + two + " * " + six + " = " + twelve);

            for (int i = 2; i < 40; i++)
            {

                string two = Numbers.DecimalToDifferentBase(2, i);
                string six = Numbers.DecimalToDifferentBase(6, i);
                string twelve = Numbers.DecimalToDifferentBase(12, i);
                Console.WriteLine("Base: " + i + " :" + two + " * " + six + " = " + twelve);
            }
        }

        [Test]
        public void eerste_getallen_base()
        {
            for (int i = 7; i < 40; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    string two = Numbers.DecimalToDifferentBase(j, i);
                  Console.WriteLine("Base: " + i + "/Getal :" + j + "InBase: " + two );
                }

                
            }
        }
    }
}

