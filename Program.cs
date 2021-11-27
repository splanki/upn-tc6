using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC6
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  san miguel -> San miguel 0
             */
            int[,] graph =  {
                          { 0, 6,0,8,0 },
                          { 0,0,16,0,0},
                          { 8,0,0,10,0},
                          { 0,0,0,0,9},
                          { 0,1,0,0,0}
            };

            //El camino más corto de Dijkstra
            Dijkstra.DijkstraAlgo(graph, 1, 5);

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
