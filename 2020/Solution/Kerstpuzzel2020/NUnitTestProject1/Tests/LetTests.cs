
using NUnit.Framework;

namespace OptimalRoute.Tests
{
    [TestFixture]
    class LegTests
    {
        [Test]
        public void Contains_finds_start_state()
        {
            Leg leggy = new Leg { End = State.Alabama, Start = State.Ohio, Length = 3.4M };
            Assert.IsTrue(leggy.Contains(State.Ohio));

        }

        [Test]
        public void Contains_finds_end_state()
        {
            Leg leggy = new Leg { End = State.Alabama, Start = State.Ohio, Length = 3.4M };
            Assert.IsTrue(leggy.Contains(State.Alabama));
        }

        [Test]
        public void Contains_finds_no_state()
        {
            Leg leggy = new Leg { End = State.Alabama, Start = State.Ohio, Length = 3.4M };
            Assert.IsFalse(leggy.Contains(State.Oregon));
        }
    }
}
