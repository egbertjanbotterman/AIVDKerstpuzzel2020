using Kerstpuzzel;
using Kerstpuzzel.Text;
using Kerstpuzzel.Text.Decryption;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kerstpuzzel2020
{
    [TestFixture]
    public class Opgave23
    {

        private string ciphertekst = "GFLTNXWDCTULTQFYBZZTUOQYTQNHMPBWVSQPLZCUQUNHZCEOKUCQKIRCVGHKCTZTNWUWZCZPLTQFGFBWUVHALF";

        private string naeerstedecipher = "FDFKTQPIFSLBXFGXKUXKMBRXXFATUMIZMVPMBULMPRATVLSIZLFMEBMGYCTHFSXKIXPZVLWUFKFNFDIZMZYHGD";

        [Test]
        public void Oplissen()
        {

            Playfair pf = new Playfair("SETHKOIN");
            Assert.AreEqual(naeerstedecipher, pf.Decrypt(ciphertekst));
        }

        [Test]
        public void BruteForceRules()
        {
            //LEtters in spionnen namen RLWKON

            Permutaties.ClearPermutations();
            Permutaties.GetPermutations("RLWKON");
            List<string> possiblities = new List<string>();
            string filename = "Opg23";
            BestandHelper.AddToFile(filename, "Here we go");
            int count = 0;

            foreach (var key in Permutaties.Permutations)
            {
             
                Playfair pf = new Playfair(key);
                string found = pf.Sanatize(pf.Decrypt(naeerstedecipher));
                if (Text.ContainsKeyWords(found))
                {
                    BestandHelper.AddToFile(filename, "Key: " + key.ToString());
                    BestandHelper.AddToFile(filename, found);
                    count++;
                }
            }

            BestandHelper.AddToFile(filename, "Aantal gevonden:" +count);
        }
    }
}
