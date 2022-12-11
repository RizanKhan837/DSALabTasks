using System;
using System.Collections.Generic;

namespace BinaryTreeExample
{
    // Define a node in the binary tree
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value) {
            this.Value = value;
        }
    }

    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree() {
            this.Root = null;
        }

        // Perform a pre-order traversal of the binary tree and print the values
        public void PreOrderTraversal()
        {
            Console.Write("Pre-order traversal: ");
            PreOrderTraversal(Root);
            Console.WriteLine();
        }

        private void PreOrderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }

            // Print the value of the current node
            Console.Write($"{node.Value} ");

            // Recursively traverse the left subtree
            PreOrderTraversal(node.Left);

            // Recursively traverse the right subtree
            PreOrderTraversal(node.Right);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a binary tree
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            // Perform a pre-order traversal and print the values
            tree.PreOrderTraversal();

            Console.ReadLine();
        }
    }
}
