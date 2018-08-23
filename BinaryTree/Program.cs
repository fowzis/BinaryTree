using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BTNode
    {
        public int Data { get; set; }

        public BTNode LeftChild { get; set; }
        public BTNode RightChild { get; set; }

        public BTNode(int data)
        {
            Data = data;
        }
    }

    class BinaryTree
    {
        public BTNode Root { get; set; }

        public BTNode Prefix(BTNode rootNode)
        {
            return null;
        }

        public BTNode Infix(BTNode rootNode)
        {
            return null;
        }

        public BTNode Postfix(BTNode rootNode)
        {
            return null;
        }

        public bool Insert(int data)
        {

            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var testData = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}
