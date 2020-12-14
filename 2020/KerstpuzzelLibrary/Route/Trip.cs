using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerstpuzzel.Route
{
    public class Trip
    {
        //Find the shortest route


        public static void DijkstraAlgoritme(Node currentNode, List<Leg> distancesList)
        {
            //Het algoritme werkt als volgt:
            //A.Geef de beginknoop voorlopig afstand 0 (dat noemen we de huidige knoop) en alle andere knopen voorlopige afstand ∞ (die noemen we niet-bezochte knopen).
            currentNode.Distance = 0;
            Node node = visitNeighbours(currentNode, distancesList);


            foreach (Node nod1 in node.Neighbours)
            {
                Console.WriteLine("NOD: " + nod1.Reference);
                if (nod1.shortestLeg != null)
                {
                    Console.WriteLine("Leg: " + nod1.shortestLeg.Start.Reference + " " + nod1.shortestLeg.End.Reference);
                }
            }


        }

        private static Node visitNeighbours(Node currentNode, List<Leg> distancesList)
        {
            foreach (Node neighbour in currentNode.Neighbours)
            {
                //B.Bekijk alle directe buren van de huidige knoop.Voor elk van die knopen kun je twee afstanden vinden:
                //1.  de voorlopige afstand die er al bij staat
                //2.  de voorlopige afstand van de huidige knoop plus de lengte van de verbindingslijn vanaf de huidige knoop naar deze
                double distance = 0;

                foreach (Leg leg in distancesList)
                {
                    if ((leg.Start.Reference.Equals(currentNode.Reference) && leg.End.Reference.Equals(neighbour.Reference)) ||
                        (leg.End.Reference.Equals(currentNode.Reference) && leg.Start.Reference.Equals(neighbour.Reference)))
                    {
                        distance = leg.Length;
                        break;
                    }
                }
                if (distance == 0) { throw new Exception("Geen afstand tussen " + currentNode.Reference + neighbour.Reference); }

                if (distance < neighbour.Distance)
                {

                    //Kies de kortste afstand van beiden.Dat wordt de nieuwe voorlopige afstand van deze knoop.
                    //Als de aftand wijzigt dan is dit de nieuwe kortste route naar deze node, de vorige route vervalt
                    neighbour.shortestLeg = new Leg() { Start = currentNode, End = neighbour, Length = distance };
                    neighbour.Distance = distance;
                }
            }
            //C.Als je alle buurknopen hebt gehad wordt de huidige knoop nu een bezochte knoop.
            currentNode.Visited = true;

            //Kies als nieuwe huidige knoop de knoop met de kleinste voorlopige afstand.
            Node newNode = currentNode.Neighbours.OrderBy(x => x.Distance).FirstOrDefault(y => y.Visited == false);
            //Ga weer naar stap B.
            if (newNode == null)
            {
                return currentNode;
            }
            return visitNeighbours(newNode, distancesList);
        }
    }
}

