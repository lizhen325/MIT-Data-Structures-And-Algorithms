using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{
    public class AVL
    {
        public Node root;
        public void Insert(int data)
        {
            Node newNode = new Node(data);
            if (root == null)
                root = newNode;
            else
                root = RecursiveInsert(root, newNode);
        }

        private Node RecursiveInsert(Node current, Node newNode)
        {
            if (current == null)
            {
                current = newNode;
                return current;
            }
            else if (newNode.Data < current.Data)
            {
                current.left = RecursiveInsert(current.left, newNode);
                current = BalanceTree(current);
            }
            else if (newNode.Data > current.Data)
            {
                current.right = RecursiveInsert(current.right, newNode);
                current = BalanceTree(current);
            }
            return current;
        }

        private Node BalanceTree(Node current)
        {
            int BalancedHeight = BalanceFactor(current);
            if (BalancedHeight > 1)
            {
                if (BalanceFactor(current.left) > 0)
                    current = RotateLL(current);
                else
                    current = RotateLR(current);
            }
            else if (BalancedHeight < -1)
            {
                if (BalanceFactor(current.right) > 0)
                    current = RotateLR(current);
                else
                    current = RotateRR(current);
            }
            return current;
        }

        private int GetHeight(Node current)
        {
            if (current != null)
            {
                int leftHeight = GetHeight(current.left);
                int rightHeight = GetHeight(current.right);
                return Math.Max(leftHeight, rightHeight) + 1;
            }
            return 0;
        }

        private int BalanceFactor(Node current)
        {
            int left = GetHeight(current.left);
            int right = GetHeight(current.right);
            return left - right;
        }

        private Node RotateLL(Node parent)
        {
            Node pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            return pivot;
        }

        private Node RotateRR(Node parent)
        {
            Node pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            return pivot;
        }

        private Node RotateLR(Node parent)
        {
            Node pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }

        private Node RotateRL(Node parent)
        {
            Node pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }

        private void Inorder(Node parent)
        {
            if (parent != null)
            {
                Inorder(parent.left);
                Console.Write(parent.Data + ", ");
                Inorder(parent.right);
            }
        }

        private bool SearchNode(int data, Node node)
        {
            if (node == null)
                return false;
            if (node.Data == data)
                return true;
            else if (node.Data < data)
                return SearchNode(data, node.right);
            else if (node.Data > data)
                return SearchNode(data, node.left);
            return false;
        }

        public void Search(int key)
        {
            if (SearchNode(key, root))
            {
                Console.WriteLine("found {0}",root.Data);
            }
            else
                Console.WriteLine("not found");
        }

        public void Display()
        {
            Inorder(root);
        }

        public void GetBalancedFactor()
        {
            Console.WriteLine(BalanceFactor(root));
        }
    }
}
