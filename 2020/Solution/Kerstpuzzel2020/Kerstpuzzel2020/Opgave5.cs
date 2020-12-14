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

            for (int i = 10; i < 64; i++)
            {
                long s = 12;
                
                string a = Numbers.DecimalToDifferentBase(s, i);
                Console.WriteLine("Base: " + i + " :" + a);
            }
        }
        }
    }

