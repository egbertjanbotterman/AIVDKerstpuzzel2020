using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstpuzzel.Text
{
    [TestFixture]
    class PermutatiesTest
    {
        [Test]
        public void getPermutaties()
        {
            Permutaties.ClearPermutations();
            Permutaties.GetPermutations("ABC");
            Assert.AreEqual(6, Permutaties.Permutations.Count);
        }
    }
}
