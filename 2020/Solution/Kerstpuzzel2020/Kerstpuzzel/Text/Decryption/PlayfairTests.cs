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
    }
}
