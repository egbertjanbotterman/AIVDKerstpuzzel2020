using KerstpuzzelLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kerstpuzzel2020
{
    [TestFixture]
    class Opgave11
    {
        [Test]
        public void find_4_letter_word_combinations()
        {
            List<Tuple<string, string>> eersteLetter = new List<Tuple<string, string>>();
            int eersteIndex = 11;

            List<Tuple<string, string>> tweedeLetter = new List<Tuple<string, string>>();
            int tweedeIndex = 3;

            List<Tuple<string, string>> derdeLetter = new List<Tuple<string, string>>();
            int derdeIndex = 14;

            List<Tuple<string, string>> vierdeLetter = new List<Tuple<string, string>>();
            int vierdeIndex = 2;

            List<Tuple<string, string>> woordjes = new List<Tuple<string, string>>();


            foreach (var item in Alfabet.A1B2)
            {
                if (item.Value > eersteIndex)
                {
                    eersteLetter.Add(new Tuple<string, string>(item.Key, Alfabet.A1B2.FirstOrDefault(x => x.Value == (item.Value - eersteIndex)).Key));

                }
                if (item.Value > tweedeIndex)
                {
                    tweedeLetter.Add(new Tuple<string, string>(item.Key, Alfabet.A1B2.FirstOrDefault(x => x.Value == (item.Value - tweedeIndex)).Key));

                }
                if (item.Value > derdeIndex)
                {
                    derdeLetter.Add(new Tuple<string, string>(item.Key, Alfabet.A1B2.FirstOrDefault(x => x.Value == (item.Value - derdeIndex)).Key));

                }
                if (item.Value > vierdeIndex)
                {
                    vierdeLetter.Add(new Tuple<string, string>(item.Key, Alfabet.A1B2.FirstOrDefault(x => x.Value == (item.Value - vierdeIndex)).Key));

                }
            }

            foreach (Tuple<string, string> een in eersteLetter)
            {
                foreach (Tuple<string, string> twee in tweedeLetter)
                {
                    foreach (Tuple<string, string> drie in derdeLetter)
                    {
                        foreach (Tuple<string, string> vier in vierdeLetter)
                        {
                            string woord1 = een.Item1 + twee.Item1 + drie.Item1 + vier.Item1;
                            string woord2 = een.Item2 + twee.Item2 + drie.Item2 + vier.Item2;

                            woordjes.Add(new Tuple<string,string>(woord1, woord2));                            
                        }
                    }
                }
            }

            BestandHelper.SaveObject<List<Tuple<string, string>>>(woordjes, @"c:\temp\woordjes");
        }
    }
}
