using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreathFirstSearch
{
    public class Vertex
    {
        public char Data;
        public Node firstEdge;
        public bool visited;
        public Vertex(char data)
        {
            Data = data;
        }
    }
}
