﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{
    public class Node
    {
        public int Data { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public Node(int data)
        {
            Data = data;
        }
    }
}
