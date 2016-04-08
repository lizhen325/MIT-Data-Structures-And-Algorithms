using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreathFirstSearch
{
    public class DFS
    {
        public static void DFSTraversal(Vertex v)
        {
            v.visited = true;
            Console.Write(v.Data + " ");
            Node node = v.firstEdge;
            while(node != null)
            {
                if(node.adjvex.visited == false)
                {
                    DFSTraversal(node.adjvex);
                }
                node = node.next;
            }
        }
    }
}
