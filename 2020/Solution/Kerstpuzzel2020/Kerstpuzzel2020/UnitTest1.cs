using Kerstpuzzel.Route;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kerstpuzzel2020.Teaser
{
    [TestFixture]
    public class Teaser1
    {
        [Test]
        public void SolveTeaser1()
        {
            List<Node> nodeList = buildMap();

            //Voor nu vanaf 1 aflopen, voor definitief alle 17 proberen
            Node firstNode = nodeList.First();

            Trip.DijkstraAlgoritme(firstNode, LegList);
        }


        private List<Node> buildMap()
        {
            List<Node> nodeList = new List<Node>();

            //Iedere staat is een node
            foreach (State state in Enum.GetValues(typeof(State)).Cast<State>())
            {
                var node = new Node(state);
                nodeList.Add(node);
            }
            //En alle nodes kunnen bij elkaar komen
            foreach (Node node in nodeList)
            {
                foreach (Node node2 in nodeList.ToList())
                {
                    if(node2.Equals(node)) { continue; }
                    node.Neighbours.Add(node2);
                }
                               
            }

            return nodeList;
        }

        private List<Leg> LegList = new List<Leg>()
          {
 new Leg (){Start = new Node(State.Texas), End=new Node(State.Alabama), Length=4.4 },
new Leg () {Start = new Node(State.Nebraska), End=new Node(State.Alabama), Length=6 },
new Leg () {Start = new Node(State.Arkansas), End=new Node(State.Alabama), Length=2.4 },
new Leg () {Start = new Node(State.SouthCarolina), End=new Node(State.Alabama), Length=2.3 },
new Leg () {Start = new Node(State.RhodeIsland), End=new Node(State.Alabama), Length=6.5 },
new Leg () {Start = new Node(State.Ohio), End=new Node(State.Alabama), Length=3.8 },
new Leg () {Start = new Node(State.Florida), End=new Node(State.Alabama), Length=2.4 },
new Leg () {Start = new Node(State.Georgia), End=new Node(State.Alabama), Length=1.3 },
new Leg () {Start = new Node(State.Nevada), End=new Node(State.Alabama), Length=10.8 },
new Leg () {Start = new Node(State.Idaho), End=new Node(State.Alabama), Length=10.7 },
new Leg () {Start = new Node(State.Tennesse), End=new Node(State.Alabama), Length=1.7 },
new Leg () {Start = new Node(State.Oregon), End=new Node(State.Alabama), Length=11.9 },
new Leg () {Start = new Node(State.Virginia), End=new Node(State.Alabama), Length=4 },
new Leg () {Start = new Node(State.Minnesota), End=new Node(State.Alabama), Length=6.9 },
new Leg () {Start = new Node(State.Arizona), End=new Node(State.Alabama), Length=8.8 },
new Leg () {Start = new Node(State.Illinois), End=new Node(State.Alabama), Length=3.3 },
new Leg () {Start = new Node(State.Nebraska), End=new Node(State.Texas), Length=4 },
new Leg () {Start = new Node(State.Arkansas), End=new Node(State.Texas), Length=2.5 },
new Leg () {Start = new Node(State.SouthCarolina), End=new Node(State.Texas), Length=6.4 },
new Leg () {Start = new Node(State.RhodeIsland), End=new Node(State.Texas), Length=2.9 },
new Leg () {Start = new Node(State.Ohio), End=new Node(State.Texas), Length=6.4 },
new Leg () {Start = new Node(State.Florida), End=new Node(State.Texas), Length=6.5 },
new Leg () {Start = new Node(State.Georgia), End=new Node(State.Texas), Length=5.5 },
new Leg () {Start = new Node(State.Nevada), End=new Node(State.Texas), Length=7 },
new Leg () {Start = new Node(State.Idaho), End=new Node(State.Texas), Length=7.4 },
new Leg () {Start = new Node(State.Tennesse), End=new Node(State.Texas), Length=4.3 },
new Leg () {Start = new Node(State.Oregon), End=new Node(State.Texas), Length=8.4 },
new Leg () {Start = new Node(State.Virginia), End=new Node(State.Texas), Length=7.5 },
new Leg () {Start = new Node(State.Minnesota), End=new Node(State.Texas), Length=6.5 },
new Leg () {Start = new Node(State.Arizona), End=new Node(State.Texas), Length=4.6 },
new Leg () {Start = new Node(State.Illinois), End=new Node(State.Texas), Length=4.6 },
new Leg () {Start = new Node(State.Arkansas), End=new Node(State.Nebraska), Length=3.7 },
new Leg () {Start = new Node(State.SouthCarolina), End=new Node(State.Nebraska), Length=7 },
new Leg () {Start = new Node(State.RhodeIsland), End=new Node(State.Nebraska), Length=8.7 },
new Leg () {Start = new Node(State.Ohio), End=new Node(State.Nebraska), Length=5.3 },
new Leg () {Start = new Node(State.Florida), End=new Node(State.Nebraska), Length=8.4 },
new Leg () {Start = new Node(State.Georgia), End=new Node(State.Nebraska), Length=6.5 },
new Leg () {Start = new Node(State.Nevada), End=new Node(State.Nebraska), Length=5.9 },
new Leg () {Start = new Node(State.Idaho), End=new Node(State.Nebraska), Length=5 },
new Leg () {Start = new Node(State.Tennesse), End=new Node(State.Nebraska), Length=4.5 },
new Leg () {Start = new Node(State.Oregon), End=new Node(State.Nebraska), Length=6.5 },
new Leg () {Start = new Node(State.Virginia), End=new Node(State.Nebraska), Length=6.9 },
new Leg () {Start = new Node(State.Minnesota), End=new Node(State.Nebraska), Length=2.7 },
new Leg () {Start = new Node(State.Arizona), End=new Node(State.Nebraska), Length=5 },
new Leg () {Start = new Node(State.Illinois), End=new Node(State.Nebraska), Length=3.5 },
new Leg () {Start = new Node(State.SouthCarolina), End=new Node(State.Arkansas), Length=4.2 },
new Leg () {Start = new Node(State.RhodeIsland), End=new Node(State.Arkansas), Length=7.4 },
new Leg () {Start = new Node(State.Ohio), End=new Node(State.Arkansas), Length=4 },
new Leg () {Start = new Node(State.Florida), End=new Node(State.Arkansas), Length=4.9 },
new Leg () {Start = new Node(State.Georgia), End=new Node(State.Arkansas), Length=3.4 },
new Leg () {Start = new Node(State.Nevada), End=new Node(State.Arkansas), Length=8.5 },
new Leg () {Start = new Node(State.Idaho), End=new Node(State.Arkansas), Length=8.3 },
new Leg () {Start = new Node(State.Tennesse), End=new Node(State.Arkansas), Length=1.6 },
new Leg () {Start = new Node(State.Oregon), End=new Node(State.Arkansas), Length=9.5 },
new Leg () {Start = new Node(State.Virginia), End=new Node(State.Arkansas), Length=5 },
new Leg () {Start = new Node(State.Minnesota), End=new Node(State.Arkansas), Length=5.2 },
new Leg () {Start = new Node(State.Arizona), End=new Node(State.Arkansas), Length=6.6 },
new Leg () {Start = new Node(State.Illinois), End=new Node(State.Arkansas), Length=2.4 },
new Leg () {Start = new Node(State.RhodeIsland), End=new Node(State.SouthCarolina), Length=4.5 },
new Leg () {Start = new Node(State.Ohio), End=new Node(State.SouthCarolina), Length=2.8 },
new Leg () {Start = new Node(State.Florida), End=new Node(State.SouthCarolina), Length=2.5 },
new Leg () {Start = new Node(State.Georgia), End=new Node(State.SouthCarolina), Length=2.2 },
new Leg () {Start = new Node(State.Nevada), End=new Node(State.SouthCarolina), Length=12.6 },
new Leg () {Start = new Node(State.Idaho), End=new Node(State.SouthCarolina), Length=12 },
new Leg () {Start = new Node(State.Tennesse), End=new Node(State.SouthCarolina), Length=2.6 },
new Leg () {Start = new Node(State.Oregon), End=new Node(State.SouthCarolina), Length=13.2 },
new Leg () {Start = new Node(State.Virginia), End=new Node(State.SouthCarolina), Length=2 },
new Leg () {Start = new Node(State.Minnesota), End=new Node(State.SouthCarolina), Length=7 },
new Leg () {Start = new Node(State.Arizona), End=new Node(State.SouthCarolina), Length=3.7 },
new Leg () {Start = new Node(State.Illinois), End=new Node(State.SouthCarolina), Length=3.6 },
new Leg () {Start = new Node(State.Ohio), End=new Node(State.RhodeIsland), Length=3.6 },
new Leg () {Start = new Node(State.Florida), End=new Node(State.RhodeIsland), Length=6.8 },
new Leg () {Start = new Node(State.Georgia), End=new Node(State.RhodeIsland), Length=5.5 },
new Leg () {Start = new Node(State.Nevada), End=new Node(State.RhodeIsland), Length=14.5 },
new Leg () {Start = new Node(State.Idaho), End=new Node(State.RhodeIsland), Length=13.6 },
new Leg () {Start = new Node(State.Tennesse), End=new Node(State.RhodeIsland), Length=5.7 },
new Leg () {Start = new Node(State.Oregon), End=new Node(State.RhodeIsland), Length=15 },
new Leg () {Start = new Node(State.Virginia), End=new Node(State.RhodeIsland), Length=2.6 },
new Leg () {Start = new Node(State.Minnesota), End=new Node(State.RhodeIsland), Length=7.2 },
new Leg () {Start = new Node(State.Arizona), End=new Node(State.RhodeIsland), Length=13.5 },
new Leg () {Start = new Node(State.Illinois), End=new Node(State.RhodeIsland), Length=5.6 },
new Leg () {Start = new Node(State.Florida), End=new Node(State.Ohio), Length=5.3 },
new Leg () {Start = new Node(State.Georgia), End=new Node(State.Ohio), Length=3.2 },
new Leg () {Start = new Node(State.Nevada), End=new Node(State.Ohio), Length=11.1 },
new Leg () {Start = new Node(State.Idaho), End=new Node(State.Ohio), Length=10.3 },
new Leg() { Start = new Node(State.Tennesse), End = new Node(State.Ohio), Length = 2.4 },
new Leg() { Start = new Node(State.Oregon), End = new Node(State.Ohio), Length = 11.8 },
new Leg() { Start = new Node(State.Virginia), End = new Node(State.Ohio), Length = 1.7 },
new Leg() { Start = new Node(State.Minnesota), End = new Node(State.Ohio), Length = 4.5 },
new Leg() { Start = new Node(State.Arizona), End = new Node(State.Ohio), Length = 10 },
new Leg() { Start = new Node(State.Illinois), End = new Node(State.Ohio), Length = 1.9 },
new Leg() { Start = new Node(State.Georgia), End = new Node(State.Florida), Length = 2.2 },
new Leg() { Start = new Node(State.Nevada), End = new Node(State.Florida), Length = 13.2 },
new Leg() { Start = new Node(State.Idaho), End = new Node(State.Florida), Length = 13.3 },
new Leg() { Start = new Node(State.Tennesse), End = new Node(State.Florida), Length = 3.8 },
new Leg() { Start = new Node(State.Oregon), End = new Node(State.Florida), Length = 14.4 },
new Leg() { Start = new Node(State.Virginia), End = new Node(State.Florida), Length = 4.6 },
new Leg() { Start = new Node(State.Minnesota), End = new Node(State.Florida), Length = 9 },
new Leg() { Start = new Node(State.Arizona), End = new Node(State.Florida), Length = 11 },
new Leg() { Start = new Node(State.Illinois), End = new Node(State.Florida), Length = 5.4 },
new Leg() { Start = new Node(State.Nevada), End = new Node(State.Georgia), Length = 11.8 },
new Leg() { Start = new Node(State.Idaho), End = new Node(State.Georgia), Length = 11.4 },
new Leg() { Start = new Node(State.Tennesse), End = new Node(State.Georgia), Length = 2.1 },
new Leg() { Start = new Node(State.Oregon), End = new Node(State.Georgia), Length = 12.7 },
new Leg() { Start = new Node(State.Virginia), End = new Node(State.Georgia), Length = 2.8 },
new Leg() { Start = new Node(State.Minnesota), End = new Node(State.Georgia), Length = 7 },
new Leg() { Start = new Node(State.Arizona), End = new Node(State.Georgia), Length = 9.8 },
new Leg() { Start = new Node(State.Illinois), End = new Node(State.Georgia), Length = 3.4 },
new Leg() { Start = new Node(State.Idaho), End = new Node(State.Nevada), Length = 2.3 },
new Leg() { Start = new Node(State.Tennesse), End = new Node(State.Nevada), Length = 9.9 },
new Leg() { Start = new Node(State.Oregon), End = new Node(State.Nevada), Length = 1.9 },
new Leg() { Start = new Node(State.Virginia), End = new Node(State.Nevada), Length = 12.7 },
new Leg() { Start = new Node(State.Minnesota), End = new Node(State.Nevada), Length = 7.8 },
new Leg() { Start = new Node(State.Arizona), End = new Node(State.Nevada), Length = 2.7 },
new Leg() { Start = new Node(State.Illinois), End = new Node(State.Nevada), Length = 9.3 },
new Leg() { Start = new Node(State.Tennesse), End = new Node(State.Idaho), Length = 2.7 },
new Leg() { Start = new Node(State.Oregon), End = new Node(State.Idaho), Length = 1.4 },
new Leg() { Start = new Node(State.Virginia), End = new Node(State.Idaho), Length = 11.9 },
new Leg() { Start = new Node(State.Minnesota), End = new Node(State.Idaho), Length = 6.3 },
new Leg() { Start = new Node(State.Arizona), End = new Node(State.Idaho), Length = 4.2 },
new Leg() { Start = new Node(State.Illinois), End = new Node(State.Idaho), Length = 8.5 },
new Leg() { Start = new Node(State.Oregon), End = new Node(State.Tennesse), Length = 10.8 },
new Leg() { Start = new Node(State.Virginia), End = new Node(State.Tennesse), Length = 3.3 },
new Leg() { Start = new Node(State.Minnesota), End = new Node(State.Tennesse), Length = 5.3 },
new Leg() { Start = new Node(State.Arizona), End = new Node(State.Tennesse), Length = 8.2 },
new Leg() { Start = new Node(State.Illinois), End = new Node(State.Tennesse), Length = 1.5 },
new Leg() { Start = new Node(State.Virginia), End = new Node(State.Oregon), Length = 13.3 },
new Leg() { Start = new Node(State.Minnesota), End = new Node(State.Oregon), Length = 7.6 },
new Leg() { Start = new Node(State.Arizona), End = new Node(State.Oregon), Length = 4.6 },
new Leg() { Start = new Node(State.Illinois), End = new Node(State.Oregon), Length = 9.9 },
new Leg() { Start = new Node(State.Minnesota), End = new Node(State.Virginia), Length = 6.2 },
new Leg() { Start = new Node(State.Arizona), End = new Node(State.Virginia), Length = 11.4 },
new Leg() { Start = new Node(State.Illinois), End = new Node(State.Virginia), Length = 3.5 },
new Leg() { Start = new Node(State.Arizona), End = new Node(State.Minnesota), Length = 7.6 },
new Leg() { Start = new Node(State.Illinois), End = new Node(State.Minnesota), Length = 3.7 },
new Leg() { Start = new Node(State.Illinois), End = new Node(State.Arizona), Length = 7.9 },

          };

        public enum State
        {
            Alabama,
            Texas,
            Nebraska,
            Arkansas,
            SouthCarolina,
            RhodeIsland,
            Ohio,
            Florida,
            Georgia,
            Nevada,
            Idaho,
            Tennesse,
            Oregon,
            Virginia,
            Minnesota,
            Arizona,
            Illinois
        }
    }
}
