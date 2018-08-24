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
        public bool IsLeaf { get; set; }

        public BTNode LeftChild { get; set; }
        public BTNode RightChild { get; set; }

        public BTNode(int data)
        {
            Data = data;
            LeftChild = null;
            RightChild = null;
            IsLeaf = true;
        }
    }

    class BinaryTree
    {
        public BTNode BTRoot { get; set; }

        // (Left, Root, Right)
        public void Print_Inorder(BTNode node)
        {
            // If empty tree, return null
            if (node == null)
                return;

            // Traverse Left Subtree
            Print_Inorder(node.LeftChild);

            // handle subtree root node
            Console.Write("{0}, ", node.Data);

            // Traverse Right Subtree
            Print_Inorder(node.RightChild);
        }

        // (Root, Left, Right)
        public void Print_Preorder(BTNode node)
        {
            // If empty tree, return null
            if (node == null)
                return;

            // handle subtree root node
            Console.Write("{0}, ", node.Data);

            // Traverse Left Subtree
            Print_Preorder(node.LeftChild);

            // Traverse Right Subtree
            Print_Preorder(node.RightChild);
        }

        // (Left, Right, Root)
        public void Print_Postorder(BTNode node)
        {
            // If empty tree, return null
            if (node == null)
                return;

            // Traverse Left Subtree
            Print_Preorder(node.LeftChild);

            // Traverse Right Subtree
            Print_Preorder(node.RightChild);

            // handle subtree root node
            Console.Write("{0}, ", node.Data);
        }

        // Breadth First or Level Order Traversal
        public BTNode BFS_Leaf(BTNode node)
        {
            BTNode bTNode = null;
            Queue<BTNode> queue = new Queue<BTNode>();

            // If the tree is empty, return null
            if (node == null)
                return null;

            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                bTNode = queue.Dequeue();

                // Check if node at the queue top has any empty child
                if (bTNode.LeftChild == null || bTNode.RightChild == null)
                {
                    break;
                }
                else
                {
                    if (bTNode.LeftChild != null)
                        queue.Enqueue(bTNode.LeftChild);
                    if (bTNode.RightChild != null)
                        queue.Enqueue(bTNode.RightChild);
                }
            }

            return bTNode;
        }

        public bool Insert(int data)
        {
            BTNode LeafNode = null;
            if (BTRoot == null)
            {
                BTRoot = new BTNode(data);
            }
            else
            {
                // Get next leaf node in tree in Breadth First Search or Level Order Traversal
                LeafNode = BFS_Leaf(BTRoot);
                if (LeafNode == null)
                    return false;   // Insertion Failed.

                if (LeafNode.LeftChild == null)
                {
                    LeafNode.LeftChild = new BTNode(data);
                }
                else if (LeafNode.RightChild == null)
                {
                    LeafNode.RightChild = new BTNode(data);
                }

                if (LeafNode.LeftChild != null || LeafNode.RightChild != null)
                {
                    LeafNode.IsLeaf = false;
                }
            }

            // Insertion successful
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var testData = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            BinaryTree BT = new BinaryTree();

            foreach (var item in testData)
            {
                BT.Insert(item);
            }

            Console.WriteLine("Print Tree Inorder");
            BT.Print_Inorder(BT.BTRoot);
            Console.WriteLine();

            Console.WriteLine("Print Tree Preorder");
            BT.Print_Postorder(BT.BTRoot);
            Console.WriteLine();

            Console.WriteLine("Print Tree Postorder");
            BT.Print_Preorder(BT.BTRoot);
            Console.WriteLine();
        }
    }
}
