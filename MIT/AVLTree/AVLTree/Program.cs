using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{
    class Program
    {
        static void Main(string[] args)
        {
            AVL tree = new AVL();
            tree.Insert(2);
            tree.Insert(1);
            tree.Insert(0);
            tree.Insert(-1);
            tree.Insert(-2);
            tree.Display();
            Console.WriteLine();
            tree.GetBalancedFactor();
            tree.Search(2);
            Console.ReadKey();
        }
    }
}
