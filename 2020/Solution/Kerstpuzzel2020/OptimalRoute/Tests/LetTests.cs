
using NUnit.Framework;

namespace OptimalRoute.Tests
{
    [TestFixture]
    class LegTests
    {
        [Test]
        public void Contains_finds_start_state()
        {
            Leg leggy = new Leg { end = State.Alabama, start = State.Ohio, length = 3.4M };
            Assert.IsTrue(leggy.Contains(State.Ohio));

        }

      


    }
}
