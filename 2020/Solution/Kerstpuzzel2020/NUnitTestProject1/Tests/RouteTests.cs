using NUnit.Framework;
using OptimalRoute;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.Tests
{
    [TestFixture]
    public class RouteTests
    {
        [Test]
        public void AddLeg_does_not_add_if_start_is_not_equal_to_route_end()
        {
            Route route = new Route();
            Leg legA = new Leg() { Start = State.RhodeIsland, End = State.Nebraska, Length = 1.4M };
            route.AddLeg(legA);

            Leg legB = new Leg() { Start = State.Ohio, End = State.Tennesse, Length = 1.4M };

            Assert.IsFalse(route.AddLeg(legB));
            Assert.AreEqual(1, route.Legs.Count);
        }

        [Test]
        public void AddLeg_does_add_if_start_is_equal_to_route_end()
        {
            Route route = new Route();
            Leg legA = new Leg() { Start = State.RhodeIsland, End = State.Nebraska, Length = 1.4M };
            route.AddLeg(legA);

            Leg legB = new Leg() { Start = State.Nebraska, End = State.Tennesse, Length = 1.4M };

            Assert.IsTrue(route.AddLeg(legB));
            Assert.AreEqual(2, route.Legs.Count);
        }

        [Test]
        public void AddLeg_does_not_add_if_end_is_already_in_the_route()
        {
            Route route = new Route();
            Leg legA = new Leg() { Start = State.RhodeIsland, End = State.Nebraska, Length = 1.4M };
            route.AddLeg(legA);

            Leg legB = new Leg() { Start = State.Nebraska, End = State.RhodeIsland, Length = 1.4M };

            Assert.IsFalse(route.AddLeg(legB));
            Assert.AreEqual(1, route.Legs.Count);
        }

        [Test]
        public void AddLeg_does_add_first_leg()
        {
            Route route = new Route();
            Leg leg = new Leg() { Start = State.RhodeIsland, End = State.Nebraska, Length = 1.4M };

            Assert.IsTrue(route.AddLeg(leg));
            Assert.AreEqual(1, route.Legs.Count);
        }


        private Route GetTestroute()
        {

            return new Route
            {
                Legs = new Dictionary<int, Leg>()
                {
                    { 1, new Leg { Start = State.Alabama, End=State.Nebraska, Length=1.4M } },
                    { 2, new Leg { Start = State.Nebraska, End=State.Idaho, Length=2.5M } },
                    { 3, new Leg { Start = State.Idaho, End=State.Florida, Length=14.45M } },
                }
            };
        }



        [Test]
        public void Contains_finds_start_in_first_leg()
        {
            Route route = GetTestroute();
            Assert.True(route.Contains(State.Alabama));
        }

        [Test]
        public void Contains_finds_start_in_last_leg()
        {
            Route route = GetTestroute();
            Assert.True(route.Contains(State.Idaho));
        }

        [Test]
        public void Contains_finds_start_in_mid_leg()
        {
            Route route = GetTestroute();
            Assert.True(route.Contains(State.Nebraska));
        }

       [Test]
        public void Contains_finds_end_in_last_leg()
        {
            Route route = GetTestroute();
            Assert.True(route.Contains(State.Florida));
        }

      
        [Test]
        public void Contains_does_not_find_new_leg()
        {
            Route route = GetTestroute();
            Assert.False(route.Contains(State.Illinois));
        }

    }
}
