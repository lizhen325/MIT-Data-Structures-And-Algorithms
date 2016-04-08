using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreathFirstSearch
{
    public class Node
    {
        public Vertex adjvex;
        public Node next;
        public Node(Vertex value)
        {
            adjvex = value;
        }
    }
}
