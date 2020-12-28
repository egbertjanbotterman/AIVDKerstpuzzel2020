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
            Polybius poly = new Polybius();
            Assert.AreEqual("a", poly.Square[0, 0]);
            Assert.AreEqual("z", poly.Square[4, 4]);

        }

        [Test]
        public void SkipCHar_is_instelbaar()
        {
            Polybius poly = new Polybius("a");
            Assert.AreEqual("b", poly.Square[0, 0]);
            Assert.IsTrue(poly.Contains("j"));
            Assert.AreEqual("z", poly.Square[4, 4]);

        }
    }
}
