using NUnit.Framework;
using OptimalRoute;
using System;
using System.Collections.Generic;
using System.Linq;
using KerstpuzzelLibrary;

namespace Kerstpuzzel2020
{
    public class Teaser1
    {

        [Test]
        public void SolveTeaser1()
        {
            // List<Leg> legList = buildLegList();





        }

        const string filename = @"c:\temp\Route.xml";
        [Test]
        public void SolveTeaserLoad()
        {
            // List<Leg> legList = buildLegList();

            List<Route> routes = BestandHelper.LoadObject<List<Route>>(filename);



        }

        [Test]
        public void buildListPossibleRoutes()
        {
            Route shortest = null;

            foreach (State one in Enum.GetValues(typeof(State)).Cast<State>())
            {
                foreach (State two in Enum.GetValues(typeof(State)).Cast<State>())
                {
                    if (one == two) { continue; }

                    foreach (State three in Enum.GetValues(typeof(State)).Cast<State>())
                    {
                        if (three == one || three == two) { continue; }

                        foreach (State four in Enum.GetValues(typeof(State)).Cast<State>())
                        {
                            if (four == one || four == two || four == three) { continue; }

                            foreach (State five in Enum.GetValues(typeof(State)).Cast<State>())
                            {
                                if (five == one || five == two || five == three || five == four) { continue; }

                                foreach (State six in Enum.GetValues(typeof(State)).Cast<State>())
                                {
                                    if (six == one || six == two || six == three || six == four || six == five) { continue; }

                                    foreach (State seven in Enum.GetValues(typeof(State)).Cast<State>())
                                    {
                                        if (seven == one || seven == two || seven == three || seven == four || seven == five ||
                                            seven == six) { continue; }

                                        foreach (State eight in Enum.GetValues(typeof(State)).Cast<State>())
                                        {
                                            if (eight == one || eight == two || eight == three || eight == four || eight == five ||
                                                eight == six || eight == seven) { continue; }

                                            foreach (State nine in Enum.GetValues(typeof(State)).Cast<State>())
                                            {
                                                if (nine == one || nine == two || nine == three || nine == four || nine == five ||
                                               nine == six || nine == seven || nine == eight) { continue; }

                                                foreach (State ten in Enum.GetValues(typeof(State)).Cast<State>())
                                                {
                                                    if (ten == one || ten == two || ten == three || ten == four || ten == five ||
                                              ten == six || ten == seven || ten == eight || ten == nine) { continue; }

                                                    foreach (State eleven in Enum.GetValues(typeof(State)).Cast<State>())
                                                    {
                                                        if (eleven == one || eleven == two || eleven == three || eleven == four || eleven == five ||
                                              eleven == six || eleven == seven || eleven == eight || eleven == nine || eleven == ten) { continue; }

                                                        foreach (State twelve in Enum.GetValues(typeof(State)).Cast<State>())
                                                        {
                                                            if (twelve == one || twelve == two || twelve == three || twelve == four || twelve == five ||
                                             twelve == six || twelve == seven || twelve == eight || twelve == nine || twelve == ten ||
                                             twelve == eleven) { continue; }

                                                            foreach (State thirteen in Enum.GetValues(typeof(State)).Cast<State>())
                                                            {
                                                                if (thirteen == one || thirteen == two || thirteen == three || thirteen == four || thirteen == five ||
                                            thirteen == six || thirteen == seven || thirteen == eight || thirteen == nine || thirteen == ten ||
                                            thirteen == eleven || thirteen == twelve) { continue; }

                                                                foreach (State fourteen in Enum.GetValues(typeof(State)).Cast<State>())
                                                                {
                                                                    if (fourteen == one || fourteen == two || fourteen == three || fourteen == four || fourteen == five ||
                                           fourteen == six || fourteen == seven || fourteen == eight || fourteen == nine || fourteen == ten ||
                                           fourteen == eleven || fourteen == twelve || fourteen == thirteen) { continue; }

                                                                    foreach (State fifteen in Enum.GetValues(typeof(State)).Cast<State>())
                                                                    {
                                                                        if (fifteen == one || fifteen == two || fifteen == three || fifteen == four || fifteen == five ||
                                          fifteen == six || fifteen == seven || fifteen == eight || fifteen == nine || fifteen == ten ||
                                          fifteen == eleven || fifteen == twelve || fifteen == thirteen || fifteen == fourteen) { continue; }

                                                                        foreach (State sixteen in Enum.GetValues(typeof(State)).Cast<State>())
                                                                        {

                                                                            if (sixteen == one || sixteen == two || sixteen == three || sixteen == four || sixteen == five ||
                                         sixteen == six || sixteen == seven || sixteen == eight || sixteen == nine || sixteen == ten ||
                                         sixteen == eleven || sixteen == twelve || sixteen == thirteen || sixteen == fourteen || sixteen == fifteen) { continue; }

                                                                            foreach (State seventeen in Enum.GetValues(typeof(State)).Cast<State>())
                                                                            {
                                                                                if (seventeen == one || seventeen == two || seventeen == three || seventeen == four || seventeen == five ||
                                          seventeen == six || seventeen == seven || seventeen == eight || seventeen == nine || seventeen == ten ||
                                          seventeen == eleven || seventeen == twelve || seventeen == thirteen || seventeen == fourteen || seventeen == fifteen || seventeen == sixteen) { continue; }

                                                                                //Hier hebben we ze allemaal op volgorde

                                                                                Route route = new Route()
                                                                                {
                                                                                    Legs = new Dictionary<int, Leg>()
                                                                                    {
                                                                                        { 1, new Leg() { Start = one, End = two, Length = getLength(one,two) } },
                                                                                        { 2, new Leg() { Start = two, End = three, Length = getLength(three,two) } },
                                                                                        { 3, new Leg() { Start = three, End = four, Length = getLength(three,four) } },
                                                                                        { 4, new Leg() { Start = four, End = five, Length = getLength(four,five) } },
                                                                                        { 5, new Leg() { Start = five, End = six, Length = getLength(five,six) } },
                                                                                        { 6, new Leg() { Start = six, End = seven, Length = getLength(six,seven) } },
                                                                                        { 7, new Leg() { Start = seven, End = eight, Length = getLength(seven,eight) } },
                                                                                        { 8, new Leg() { Start = eight, End = nine, Length = getLength(eight,nine) } },
                                                                                        { 9, new Leg() { Start = nine, End = ten, Length = getLength(nine,ten)} },
                                                                                        { 10, new Leg() { Start = ten, End = eleven, Length = getLength(ten,eleven) } },
                                                                                        { 12, new Leg() { Start = eleven, End = twelve, Length = getLength(eleven,twelve) } },
                                                                                        { 13, new Leg() { Start = twelve, End = thirteen, Length = getLength(twelve,thirteen) } },
                                                                                        { 14, new Leg() { Start = thirteen, End = fourteen, Length = getLength(thirteen,fourteen) } },
                                                                                        { 15, new Leg() { Start = fourteen, End = fifteen, Length = getLength(fourteen,fifteen) } },
                                                                                        { 16, new Leg() { Start = fifteen, End = sixteen, Length = getLength(fifteen,sixteen) } },
                                                                                        { 17, new Leg() { Start = sixteen, End = seventeen, Length = getLength(sixteen,seventeen) } }
                                                                                    }
                                                                                };
                                                                                {
                                                                                    if (shortest == null ||
                                                                                        route.Length < shortest.Length)
                                                                                    {
                                                                                        shortest = route;
                                                                                        BestandHelper.SaveObject<Route>(shortest, filename);
                                                                                    }
                                                                                }

                                                                                //355 687 428 096 000 mogelijkheden .
                                                                            }

                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private decimal getLength(State one, State two)
        {
            return LegList.Find(x => (x.Start == one && x.End == two) || (x.Start == two && x.End == one)).Length;
            //throw new NotImplementedException();
        }

        private List<Leg> LegList = new List<Leg>()
          {
             new Leg (){Start = State.Texas, End=State.Alabama, Length=4.4M },
new Leg () {Start = State.Nebraska, End=State.Alabama, Length=6M },
new Leg () {Start = State.Arkansas, End=State.Alabama, Length=2.4M },
new Leg () {Start = State.SouthCarolina, End=State.Alabama, Length=2.3M },
new Leg () {Start = State.RhodeIsland, End=State.Alabama, Length=6.5M },
new Leg () {Start = State.Ohio, End=State.Alabama, Length=3.8M },
new Leg () {Start = State.Florida, End=State.Alabama, Length=2.4M },
new Leg () {Start = State.Georgia, End=State.Alabama, Length=1.3M },
new Leg () {Start = State.Nevada, End=State.Alabama, Length=10.8M },
new Leg () {Start = State.Idaho, End=State.Alabama, Length=10.7M },
new Leg () {Start = State.Tennesse, End=State.Alabama, Length=1.7M },
new Leg () {Start = State.Oregon, End=State.Alabama, Length=11.9M },
new Leg () {Start = State.Virginia, End=State.Alabama, Length=4M },
new Leg () {Start = State.Minnesota, End=State.Alabama, Length=6.9M },
new Leg () {Start = State.Arizona, End=State.Alabama, Length=8.8M },
new Leg () {Start = State.Illinois, End=State.Alabama, Length=3.3M },
new Leg () {Start = State.Nebraska, End=State.Texas, Length=4M },
new Leg () {Start = State.Arkansas, End=State.Texas, Length=2.5M },
new Leg () {Start = State.SouthCarolina, End=State.Texas, Length=6.4M },
new Leg () {Start = State.RhodeIsland, End=State.Texas, Length=2.9M },
new Leg () {Start = State.Ohio, End=State.Texas, Length=6.4M },
new Leg () {Start = State.Florida, End=State.Texas, Length=6.5M },
new Leg () {Start = State.Georgia, End=State.Texas, Length=5.5M },
new Leg () {Start = State.Nevada, End=State.Texas, Length=7M },
new Leg () {Start = State.Idaho, End=State.Texas, Length=7.4M },
new Leg () {Start = State.Tennesse, End=State.Texas, Length=4.3M },
new Leg () {Start = State.Oregon, End=State.Texas, Length=8.4M },
new Leg () {Start = State.Virginia, End=State.Texas, Length=7.5M },
new Leg () {Start = State.Minnesota, End=State.Texas, Length=6.5M },
new Leg () {Start = State.Arizona, End=State.Texas, Length=4.6M },
new Leg () {Start = State.Illinois, End=State.Texas, Length=4.6M },
new Leg () {Start = State.Arkansas, End=State.Nebraska, Length=3.7M },
new Leg () {Start = State.SouthCarolina, End=State.Nebraska, Length=7M },
new Leg () {Start = State.RhodeIsland, End=State.Nebraska, Length=8.7M },
new Leg () {Start = State.Ohio, End=State.Nebraska, Length=5.3M },
new Leg () {Start = State.Florida, End=State.Nebraska, Length=8.4M },
new Leg () {Start = State.Georgia, End=State.Nebraska, Length=6.5M },
new Leg () {Start = State.Nevada, End=State.Nebraska, Length=5.9M },
new Leg () {Start = State.Idaho, End=State.Nebraska, Length=5M },
new Leg () {Start = State.Tennesse, End=State.Nebraska, Length=4.5M },
new Leg () {Start = State.Oregon, End=State.Nebraska, Length=6.5M },
new Leg () {Start = State.Virginia, End=State.Nebraska, Length=6.9M },
new Leg () {Start = State.Minnesota, End=State.Nebraska, Length=2.7M },
new Leg () {Start = State.Arizona, End=State.Nebraska, Length=5M },
new Leg () {Start = State.Illinois, End=State.Nebraska, Length=3.5M },
new Leg () {Start = State.SouthCarolina, End=State.Arkansas, Length=4.2M },
new Leg () {Start = State.RhodeIsland, End=State.Arkansas, Length=7.4M },
new Leg () {Start = State.Ohio, End=State.Arkansas, Length=4M },
new Leg () {Start = State.Florida, End=State.Arkansas, Length=4.9M },
new Leg () {Start = State.Georgia, End=State.Arkansas, Length=3.4M },
new Leg () {Start = State.Nevada, End=State.Arkansas, Length=8.5M },
new Leg () {Start = State.Idaho, End=State.Arkansas, Length=8.3M },
new Leg () {Start = State.Tennesse, End=State.Arkansas, Length=1.6M },
new Leg () {Start = State.Oregon, End=State.Arkansas, Length=9.5M },
new Leg () {Start = State.Virginia, End=State.Arkansas, Length=5M },
new Leg () {Start = State.Minnesota, End=State.Arkansas, Length=5.2M },
new Leg () {Start = State.Arizona, End=State.Arkansas, Length=6.6M },
new Leg () {Start = State.Illinois, End=State.Arkansas, Length=2.4M },
new Leg () {Start = State.RhodeIsland, End=State.SouthCarolina, Length=4.5M },
new Leg () {Start = State.Ohio, End=State.SouthCarolina, Length=2.8M },
new Leg () {Start = State.Florida, End=State.SouthCarolina, Length=2.5M },
new Leg () {Start = State.Georgia, End=State.SouthCarolina, Length=2.2M },
new Leg () {Start = State.Nevada, End=State.SouthCarolina, Length=12.6M },
new Leg () {Start = State.Idaho, End=State.SouthCarolina, Length=12M },
new Leg () {Start = State.Tennesse, End=State.SouthCarolina, Length=2.6M },
new Leg () {Start = State.Oregon, End=State.SouthCarolina, Length=13.2M },
new Leg () {Start = State.Virginia, End=State.SouthCarolina, Length=2M },
new Leg () {Start = State.Minnesota, End=State.SouthCarolina, Length=7M },
new Leg () {Start = State.Arizona, End=State.SouthCarolina, Length=3.7M },
new Leg () {Start = State.Illinois, End=State.SouthCarolina, Length=3.6M },
new Leg () {Start = State.Ohio, End=State.RhodeIsland, Length=3.6M },
new Leg () {Start = State.Florida, End=State.RhodeIsland, Length=6.8M },
new Leg () {Start = State.Georgia, End=State.RhodeIsland, Length=5.5M },
new Leg () {Start = State.Nevada, End=State.RhodeIsland, Length=14.5M },
new Leg () {Start = State.Idaho, End=State.RhodeIsland, Length=13.6M },
new Leg () {Start = State.Tennesse, End=State.RhodeIsland, Length=5.7M },
new Leg () {Start = State.Oregon, End=State.RhodeIsland, Length=15M },
new Leg () {Start = State.Virginia, End=State.RhodeIsland, Length=2.6M },
new Leg () {Start = State.Minnesota, End=State.RhodeIsland, Length=7.2M },
new Leg () {Start = State.Arizona, End=State.RhodeIsland, Length=13.5M },
new Leg () {Start = State.Illinois, End=State.RhodeIsland, Length=5.6M },
new Leg () {Start = State.Florida, End=State.Ohio, Length=5.3M },
new Leg () {Start = State.Georgia, End=State.Ohio, Length=3.2M },
new Leg () {Start = State.Nevada, End=State.Ohio, Length=11.1M },
new Leg () {Start = State.Idaho, End=State.Ohio, Length=10.3M },
new Leg() { Start = State.Tennesse, End = State.Ohio, Length = 2.4M },
new Leg() { Start = State.Oregon, End = State.Ohio, Length = 11.8M },
new Leg() { Start = State.Virginia, End = State.Ohio, Length = 1.7M },
new Leg() { Start = State.Minnesota, End = State.Ohio, Length = 4.5M },
new Leg() { Start = State.Arizona, End = State.Ohio, Length = 10M },
new Leg() { Start = State.Illinois, End = State.Ohio, Length = 1.9M },
new Leg() { Start = State.Georgia, End = State.Florida, Length = 2.2M },
new Leg() { Start = State.Nevada, End = State.Florida, Length = 13.2M },
new Leg() { Start = State.Idaho, End = State.Florida, Length = 13.3M },
new Leg() { Start = State.Tennesse, End = State.Florida, Length = 3.8M },
new Leg() { Start = State.Oregon, End = State.Florida, Length = 14.4M },
new Leg() { Start = State.Virginia, End = State.Florida, Length = 4.6M },
new Leg() { Start = State.Minnesota, End = State.Florida, Length = 9M },
new Leg() { Start = State.Arizona, End = State.Florida, Length = 11M },
new Leg() { Start = State.Illinois, End = State.Florida, Length = 5.4M },
new Leg() { Start = State.Nevada, End = State.Georgia, Length = 11.8M },
new Leg() { Start = State.Idaho, End = State.Georgia, Length = 11.4M },
new Leg() { Start = State.Tennesse, End = State.Georgia, Length = 2.1M },
new Leg() { Start = State.Oregon, End = State.Georgia, Length = 12.7M },
new Leg() { Start = State.Virginia, End = State.Georgia, Length = 2.8M },
new Leg() { Start = State.Minnesota, End = State.Georgia, Length = 7M },
new Leg() { Start = State.Arizona, End = State.Georgia, Length = 9.8M },
new Leg() { Start = State.Illinois, End = State.Georgia, Length = 3.4M },
new Leg() { Start = State.Idaho, End = State.Nevada, Length = 2.3M },
new Leg() { Start = State.Tennesse, End = State.Nevada, Length = 9.9M },
new Leg() { Start = State.Oregon, End = State.Nevada, Length = 1.9M },
new Leg() { Start = State.Virginia, End = State.Nevada, Length = 12.7M },
new Leg() { Start = State.Minnesota, End = State.Nevada, Length = 7.8M },
new Leg() { Start = State.Arizona, End = State.Nevada, Length = 2.7M },
new Leg() { Start = State.Illinois, End = State.Nevada, Length = 9.3M },
new Leg() { Start = State.Tennesse, End = State.Idaho, Length = 2.7M },
new Leg() { Start = State.Oregon, End = State.Idaho, Length = 1.4M },
new Leg() { Start = State.Virginia, End = State.Idaho, Length = 11.9M },
new Leg() { Start = State.Minnesota, End = State.Idaho, Length = 6.3M },
new Leg() { Start = State.Arizona, End = State.Idaho, Length = 4.2M },
new Leg() { Start = State.Illinois, End = State.Idaho, Length = 8.5M },
new Leg() { Start = State.Oregon, End = State.Tennesse, Length = 10.8M },
new Leg() { Start = State.Virginia, End = State.Tennesse, Length = 3.3M },
new Leg() { Start = State.Minnesota, End = State.Tennesse, Length = 5.3M },
new Leg() { Start = State.Arizona, End = State.Tennesse, Length = 8.2M },
new Leg() { Start = State.Illinois, End = State.Tennesse, Length = 1.5M },
new Leg() { Start = State.Virginia, End = State.Oregon, Length = 13.3M },
new Leg() { Start = State.Minnesota, End = State.Oregon, Length = 7.6M },
new Leg() { Start = State.Arizona, End = State.Oregon, Length = 4.6M },
new Leg() { Start = State.Illinois, End = State.Oregon, Length = 9.9M },
new Leg() { Start = State.Minnesota, End = State.Virginia, Length = 6.2M },
new Leg() { Start = State.Arizona, End = State.Virginia, Length = 11.4M },
new Leg() { Start = State.Illinois, End = State.Virginia, Length = 3.5M },
new Leg() { Start = State.Arizona, End = State.Minnesota, Length = 7.6M },
new Leg() { Start = State.Illinois, End = State.Minnesota, Length = 3.7M },
new Leg() { Start = State.Illinois, End = State.Arizona, Length = 7.9M },


          };


    }
}
