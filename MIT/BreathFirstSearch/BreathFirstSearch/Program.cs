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
            adj.AddVertext('1');
            adj.AddVertext('2');
            adj.AddVertext('3');
            adj.AddVertext('4');
            adj.AddVertext('5');
            adj.AddVertext('6');
            adj.AddVertext('7');
            adj.AddVertext('8');
            adj.AddEdge('1', '2');
            adj.AddEdge('1', '3');
            adj.AddEdge('2', '4');
            adj.AddEdge('2', '5');
            adj.AddEdge('3', '6');
            adj.AddEdge('3', '7');
            adj.AddEdge('4', '8');
            adj.AddEdge('5', '8');
            adj.AddEdge('6', '8');
            adj.AddEdge('7', '8');
            Console.WriteLine("Adjency List: ");
            Console.WriteLine(adj.Display());
            Console.WriteLine("BFS: ");
            adj.InitVist();
            BFS.BFSTraversal(adj.items[0]);
            Console.WriteLine();
            adj.InitVist();
            Console.WriteLine("DFS:");
            DFS.DFSTraversal(adj.items[0]);
            Console.ReadKey();
        }
    }
}
