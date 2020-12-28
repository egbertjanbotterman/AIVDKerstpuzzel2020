using Kerstpuzzel;
using Kerstpuzzel.Text;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

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
            int vierdeIndex = 24;

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
                //Let op: deze is -B dus grootste eerst: MAXIMUM index is 24
                if (item.Value <= vierdeIndex)
                {
                    vierdeLetter.Add(new Tuple<string, string>(item.Key, Alfabet.A1B2.FirstOrDefault(x => x.Value == (item.Value + (26 - vierdeIndex))).Key));

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

                            if (!Text.CouldBeADutchWord(woord1) ||
                                !Text.CouldBeADutchWord(woord2))
                            {
                                continue;
                            }

                            woordjes.Add(new Tuple<string, string>(woord1, woord2));
                        }
                    }
                }
            }

            Console.WriteLine("Gevonden woordjes: " + woordjes.Count());
            BestandHelper.SaveObject<List<Tuple<string, string>>>(woordjes, @"c:\temp\woordjes");
        }

        [Test]
        public void find_8_letter_word()
        {
            List<Tuple<string, string>> eersteLetter = new List<Tuple<string, string>>();
            int eersteIndex = 11;

            List<Tuple<string, string>> tweedeLetter = new List<Tuple<string, string>>();
            int tweedeIndex = 3;

            List<Tuple<string, string>> derdeLetter = new List<Tuple<string, string>>();
            int derdeIndex = 14;

            List<Tuple<string, string>> vierdeLetter = new List<Tuple<string, string>>();
            int vierdeIndex = 24;

            List<Tuple<string, string>> woordjes = new List<Tuple<string, string>>();
            List<string> endings = new List<string>();


            //Letters verzamelen in lijstjes
            foreach (var item in Alfabet.A1B2)
            {
                //Aanname: het alfabetisch stukje is hier nog van toepassing dus tussen Trinidad en Water
                if (item.Value >= 20 && item.Value <= 23)
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
                //Let op: deze is -B dus grootste eerst: MAXIMUM index is 24
                if (item.Value <= vierdeIndex)
                {
                    vierdeLetter.Add(new Tuple<string, string>(item.Key, Alfabet.A1B2.FirstOrDefault(x => x.Value == (item.Value + (26 - vierdeIndex))).Key));

                }
            }


            foreach (var vijf in Alfabet.A1B2)
            {
                foreach (var zes in Alfabet.A1B2)
                {
                    foreach (var zeven in Alfabet.A1B2)
                    {
                        foreach (var acht in Alfabet.A1B2)
                        {

                            string ending = vijf.Key + zes.Key + zeven.Key + acht.Key;


                            endings.Add(ending);
                            Console.WriteLine(endings.Count);
                        }
                    }
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

                            foreach (var ending in endings)
                            {


                                string woord1 = een.Item1 + twee.Item1 + drie.Item1 + vier.Item1 + ending;
                                string woord2 = een.Item2 + twee.Item2 + drie.Item2 + vier.Item2 + ending;



                                if (!Text.CouldBeADutchWord(woord1) ||
                                    !Text.CouldBeADutchWord(woord2))
                                {
                                    continue;
                                }

                                woordjes.Add(new Tuple<string, string>(woord1, woord2));
                            }
                        }
                    }
                }
            }


            Console.WriteLine("Gevonden woordjes: " + woordjes.Count());
            BestandHelper.SaveObject<List<Tuple<string, string>>>(woordjes, @"c:\temp\woordjes");
        }
    }
}

