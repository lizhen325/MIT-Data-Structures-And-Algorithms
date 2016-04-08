using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreathFirstSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            AdjacencyList adj = new AdjacencyList(10);
            adj.AddVertext('A');
            adj.AddVertext('B');
            adj.AddVertext('C');
            adj.AddVertext('D');

            adj.AddEdge('A', 'B');
            adj.AddEdge('A', 'C');
            adj.AddEdge('A', 'D');
            adj.AddEdge('B', 'D');
            adj.AddEdge('B', 'C');
            Console.WriteLine(adj.Display());
            BFS.BFSTraversal(adj.items[0]);
            Console.ReadKey();
        }
    }
}
