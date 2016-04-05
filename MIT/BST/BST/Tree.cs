using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class Tree
    {
        private int data;
        private Tree l;
        private Tree r;

        public Tree() { }
        public Tree(int item, Tree left, Tree right)
        {
            data = item;
            l = left;
            r = right;
        }

        public void Insert(int item)
        {
            if (item > data)
            {
                if (r == null)
                    r = new Tree(item, null, null);
                else
                    r.Insert(item);
            }
            else if (item < data)
            {
                if (l == null)
                    l = new Tree(item, null, null);
                else
                    l.Insert(item);
            }
            else if (data == item)
                Console.WriteLine("Error: key is not unique");
        }

        public static void Inorder(Tree tree)
        {
            if (tree == null) return;
            Inorder(tree.l);
            Console.Write(tree.data + ", ");
            Inorder(tree.r);
        }

        public static void PreOrder(Tree tree)
        {
            if (tree == null) return;
            Console.Write(tree.data + ", ");
            PreOrder(tree.l);
            PreOrder(tree.r);
        }

        public static void PostOrder(Tree tree)
        {
            if (tree == null) return;
            PostOrder(tree.l);
            PostOrder(tree.r);
            Console.Write(tree.data + ", ");
        }

        public static int FindMin(Tree tree)
        {
            Tree CurrentNode = tree;
            while(CurrentNode.l != null)
                CurrentNode = CurrentNode.l;
            return CurrentNode.data;
        }

        public static int FindMax(Tree tree)
        {
            Tree CurrnetNode = tree;
            while (CurrnetNode.r != null)
                CurrnetNode = CurrnetNode.r;
            return CurrnetNode.data;
        }

        public static bool Search(int data, Tree tree)
        {
            if (tree == null)
                return false;
            if (tree.data == data)
                return true;
            else if(tree.data < data)
                return Search(data, tree.r);
            else if(tree.data > data)
                return Search(data, tree.l);
            return false;
        }

        public static int Height(Tree tree)
        {
            if (tree == null) return 0;
            else
            {
                int lHeight = Height(tree.l);
                int rHeight = Height(tree.r);
                if (lHeight >= rHeight)
                    return lHeight + 1;
                else
                    return rHeight + 1;
            }
        }
    }
}
