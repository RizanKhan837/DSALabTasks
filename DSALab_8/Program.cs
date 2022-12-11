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

        public void PostOrderTraversal()
        {
            Console.Write("Post-order traversal: ");
            PostOrderTraversal(Root);
            Console.WriteLine();
        }

        private void PostOrderTraversal(Node node)
        {
            if (node == null) {
                return;
            }

            // Recursively traverse the left subtree
            PostOrderTraversal(node.Left);

            // Recursively traverse the right subtree
            PostOrderTraversal(node.Right);

            // Print the value of the current node
            Console.Write($"{node.Value} ");
        }
        public void InOrderTraversal()
        {
            Console.Write("In-order traversal: ");
            InOrderTraversal(Root);
            Console.WriteLine();
        }

        private void InOrderTraversal(Node node)
        {
            if (node == null) {
                return;
            }

            // Recursively traverse the left subtree
            InOrderTraversal(node.Left);

            // Print the value of the current node
            Console.Write($"{node.Value} ");

            // Recursively traverse the right subtree
            InOrderTraversal(node.Right);
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
            tree.Root.Right.Left = new Node(6);
            tree.Root.Right.Right = new Node(7);

            /*            1
             *       2         3
             *     4   5     6   7          
             */            

            tree.PreOrderTraversal();
            tree.PostOrderTraversal();
            tree.InOrderTraversal();

            Console.ReadLine();
        }
    }
}
