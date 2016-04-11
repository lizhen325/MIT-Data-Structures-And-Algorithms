using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    class Program
    {
        static void Main()
        {
            int[,] a = new int[,] { { 0, 6, 3, -1, -1, -1 }, { 6, 0, 2, 5, -1, -1 }, { 3, 2, 0, 3, 4, -1 }, { -1, 5, 3, 0, 2, 3 }, { -1, -1, 4, 2, 0, 5 }, { -1, -1, -1, 3, 5, 0 } };
            int n = 6;
            GraphClass gc = new GraphClass();
            gc.CreateMGraph(n, a);
            Console.WriteLine(gc.DispMGraph());
            gc.Dijkstra();
            Console.ReadKey();
        }
    }
}
