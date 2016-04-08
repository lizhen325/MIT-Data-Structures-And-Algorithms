using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreathFirstSearch
{
    public class AdjacencyList
    {
        public List<Vertex> items;
        public AdjacencyList(int capacity)
        {
            items = new List<Vertex>(capacity);
        }
        
        public bool Contains(char item)
        {
            foreach(Vertex v in items)
            {
                if (v.Data.Equals(item))
                    return true;
            }
            return false;
        }

        public void AddVertext(char item)
        {
            if(Contains(item))
            {
                Console.WriteLine("Can not duplicate vertex");
                return;
            }
            items.Add(new Vertex(item));
        }

        private Vertex Find(char item)
        {
            foreach(Vertex v in items)
            {
                if (v.Data == item)
                    return v;
            }
            return null;
        }

        public void AddDirectedEdge(Vertex from, Vertex to)
        {
            Node temp;
            Node node = from.firstEdge;
            temp = node;
            if (from.firstEdge == null)
            {
                from.firstEdge = new Node(to);
            }
            else
            {
                
                while(node !=null)
                {
                    if(node.adjvex.Data == to.Data)
                    {
                        Console.WriteLine("Edge Cannot be duplicate");
                        return;
                    }
                    temp = node;
                    node = node.next;
                }
                temp.next = new Node(to);
            }
        }

        public void AddEdge(char from, char to)
        {
            Vertex fromV = Find(from);
            if(fromV == null )
            {
                Console.WriteLine("there is no head");
                return;
            }
            Vertex toV = Find(to);
            if(toV == null)
            {
                return;
            }
            AddDirectedEdge(fromV, toV);
            AddDirectedEdge(toV, fromV);
        }

        public string Display()
        {
            string s = string.Empty;
            foreach(Vertex v in items)
            {
                s += v.Data.ToString() + ":";
                if(v.firstEdge != null)
                {
                    Node temp = v.firstEdge;
                    while(temp != null)
                    {
                        s += temp.adjvex.Data.ToString();
                        temp = temp.next;
                    }
                }
                s += "\r\n";
            }
            return s;
        }
        public void InitVist()
        {
            foreach(Vertex v in items)
            {
                v.visited = false;
            }
        }
    }
}
