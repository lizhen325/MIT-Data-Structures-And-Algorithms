using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree(7,null,null);
            tree.Insert(1);
            tree.Insert(6);
            tree.Insert(2);
            tree.Insert(4);
            tree.Insert(5);
            tree.Insert(3);
            Tree.Inorder(tree);
            Console.WriteLine();
            Console.WriteLine("Min: {0}", Tree.FindMin(tree));
            Console.WriteLine("Max: {0}", Tree.FindMax(tree));
            Console.WriteLine(Tree.Search(3, tree));
            Console.Write("Height: {0}", Tree.Height(tree));
            Console.ReadKey();
        }
    }
}
