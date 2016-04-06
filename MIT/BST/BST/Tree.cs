using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class Tree
    {
        public int data;
        public Tree l;
        public Tree r;

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

        public Tree Delete(int data, Tree tree)
        {
            Tree parent = tree;
            Tree current = tree;
            while(true)
            {
                if (data < current.data)
                {
                    if (current == null)
                        break;
                    parent = current;
                    current = current.l;
                }
                else if (data > current.data)
                {
                    if (current == null)
                        break;
                    parent = current;
                    current = current.r;
                }
                else
                    break;
            }
            if (current.l == null && current.r == null)
            {
                //如果被删节点是根节点，且没有左右孩子
                if (current == tree && tree.l == null && tree.r == null)
                {
                    tree = null;
                }
                else if (current.data < parent.data)
                    parent.l = null;
                else
                    parent.r = null;
            }
            else if (current.l != null && current.r == null)
            {
                if (current.data < parent.data)
                    parent.l = current.l;
                else
                    parent.r = current.l;
            }
            else if (current.l == null && current.r != null)
            {
                if (current.data < parent.data)
                    parent.l = current.r;
                else
                    parent.r = current.r;
            }
            else
            {
                Tree temp;
                //先判断是父节点的左孩子还是右孩子
                if (current.data < parent.data)
                {

                    parent.l = current.l;
                    temp = current.l;
                    //寻找被删除节点最深的右孩子
                    while (temp.r != null)
                    {
                        temp = temp.r;
                    }
                    temp.r = current.r;


                }
                //右孩子
                else if (current.data > parent.data)
                {
                    parent.r = current.r;
                    temp = current.l;
                    //寻找被删除节点最深的左孩子
                    while (temp.l != null)
                    {
                        temp = temp.l;
                    }
                    temp.r = current.r;
                }
                //当被删节点是根节点，并且有两个孩子时
                else
                {
                    temp = current.l;
                    while (temp.r != null)
                    {
                        temp = temp.r;
                    }
                    temp.r = tree.r;
                    tree = current.l;
                }
            }
            return current;
        }
    }
}
