using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreathFirstSearch
{
    public class BFS
    {
        public static void BFSTraversal(Vertex v)
        {
            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(v);
            Console.Write(v.Data + " ");
            v.visited = true;
            while (queue.Count != 0)
            {
                Node node = queue.Dequeue().firstEdge;
                while (node != null)
                {
                    if (node.adjvex.visited == false)
                    {
                        Console.Write(node.adjvex.Data + " ");
                        node.adjvex.visited = true;
                        queue.Enqueue(node.adjvex);
                    }
                    node = node.next;
                }
            }
        }
    }
}
