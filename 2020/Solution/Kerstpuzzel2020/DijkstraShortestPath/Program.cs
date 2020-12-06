﻿using System;

namespace DijkstraShortestPath
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] graph =  {
                { 0, 6, 0, 0, 0, 0, 0, 9, 0 },
                { 6, 0, 9, 0, 0, 0, 0, 11, 0 },
                { 0, 9, 0, 5, 0, 6, 0, 0, 2 },
                { 0, 0, 5, 0, 9, 16, 0, 0, 0 },
                { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                { 0, 0, 6, 0, 10, 0, 2, 0, 0 },
                { 0, 0, 0, 16, 0, 2, 0, 1, 6 },
                { 9, 11, 0, 0, 0, 0, 1, 0, 5 },
                { 0, 0, 2, 0, 0, 0, 6, 5, 0 }
            };

            Dijkstra.DijkstraAlgo(graph, 0, 9);
        }
    }
}
