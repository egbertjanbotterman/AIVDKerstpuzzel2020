using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstpuzzel.Text.Decryption
{
    [TestFixture]
    public class PolybiusTests
    {
        [Test]
        public void PopulateVultPolybius()
        {
            Polybius poly = new Polybius("");
            Assert.AreEqual("A", poly.Square[0, 0]);
            Assert.AreEqual("Z", poly.Square[4, 4]);

        }

        [Test]
        public void SkipCHar_is_instelbaar()
        {
            Polybius poly = new Polybius("","a");
            Assert.AreEqual("B", poly.Square[0, 0]);
            Assert.IsTrue(poly.Contains("j"));
            Assert.AreEqual("Z", poly.Square[4, 4]);

        }

        [Test]
        public void Get_coordinates_geeft_positie_van_letter()
        {
            Polybius poly = new Polybius("","A");
            int[] pos = poly.GetCoordinates("M");

            Assert.AreEqual(2, pos[0]);
            Assert.AreEqual(1, pos[1]);
        }

        [Test]
        public void Get_value_geeft_waarde_op_positier()
        {
            Polybius poly = new Polybius("", "A");
            Assert.AreEqual("M", poly.GetValue(new int[] { 2, 1 }));         

        }
    }
}
