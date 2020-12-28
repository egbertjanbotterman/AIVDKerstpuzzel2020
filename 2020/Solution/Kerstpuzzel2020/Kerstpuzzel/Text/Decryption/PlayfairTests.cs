using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstpuzzel.Text.Decryption
{
    [TestFixture]
    public class PlayfairTests
    {
        [Test]
        public void Damn_recursion()
        {
            Playfair pf = new Playfair();
            pf.Decrypt("DitIsMijnTekst");
        }

        [Test]
        public void Decrypt()
        {
            Playfair pf = new Playfair("SETHKOIN");
            string sol = pf.Decrypt("DIKTNKTWTITWHPEHTEHNRDSPNYBHHKDIQAOYBCFHDONDHPHTSESQTHTWTIBAPIPHKCKPHTFZ");
            Assert.AreEqual("IEHEBTEXENEXERSTESTAPGEMAXAKTHIERNAVOLGTCIIFERTEKSTMETEXENANDERESLEUTELX", sol);

        }

        [Test]
        public void SSanatizetst()
        {
            Playfair pf = new Playfair("SETHKOIN");
            string sol = pf.Decrypt("DIKTNKTWTITWHPEHTEHNRDSPNYBHHKDIQAOYBCFHDONDHPHTSESQTHTWTIBAPIPHKCKPHTFZ");
            string sanatized = pf.Sanatize(sol);
            Assert.AreEqual("IEHEBTEENEERSTESTAPGEMAAKTHIERNAVOLGTCIIFERTEKSTMETEENANDERESLEUTEL", sanatized);

        }
    }
}
