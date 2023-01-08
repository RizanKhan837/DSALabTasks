using System;

namespace DSALab_9
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }

    class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree() {
            root = null;
        }

        public void Insert(int data) {
            root = Insert(root, data);
        }

        private Node Insert(Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);
            }
            else
            {
                if (data <= node.data)
                {
                    node.left = Insert(node.left, data);
                }
                else
                {
                    node.right = Insert(node.right, data);
                }
            }
            return node;
        }

        public bool Search(int data) {
            return Search(root, data);
        }

        private bool Search(Node node, int data)
        {
            if (node == null)
            {
                return false;
            }
            if (node.data == data)
            {
                return true;
            }
            else if (data < node.data)
            {
                return Search(node.left, data);
            }
            else
            {
                return Search(node.right, data);
            }
        }

        public void PreorderTraversal() {
            PreorderTraversal(root);
        }

        private void PreorderTraversal(Node node)
        {
            if (node != null)
            {
                Console.Write(node.data + " ");
                PreorderTraversal(node.left);
                PreorderTraversal(node.right);
            }
        }

        public void InorderTraversal() {
            InorderTraversal(root);
        }

        private void InorderTraversal(Node node)
        {
            if (node != null)
            {
                InorderTraversal(node.left);
                Console.Write(node.data + " ");
                InorderTraversal(node.right);
            }
        }

        public void PostorderTraversal() {
            PostorderTraversal(root);
        }

        private void PostorderTraversal(Node node)
        {
            if (node != null)
            {
                PostorderTraversal(node.left);
                PostorderTraversal(node.right);
                Console.Write(node.data + " ");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(20);
            bst.Insert(40); 
            bst.Insert(70);
            bst.Insert(60);
            bst.Insert(80);

            Console.WriteLine("Preorder traversal: ");
            bst.PreorderTraversal();
            Console.WriteLine();

            Console.WriteLine("Inorder traversal: ");
            bst.InorderTraversal();
            Console.WriteLine();

            Console.WriteLine("Postorder traversal: ");
            bst.PostorderTraversal();
            Console.WriteLine();

            int searchKey = 90;
            if (bst.Search(searchKey)) {
                Console.WriteLine(searchKey + " is found in the tree.");
            }
            else {
                Console.WriteLine(searchKey + " is not found in the tree.");
            }

            /** 
             * This program defines a Node class to represent a node in the tree, with properties data, left, and right to store the data value, left child, and right child of the node, respectively. 
             

             * The BinarySearchTree class represents the tree itself, with a private root node and methods for inserting, searching, and traversing the tree. 
             
             
             * The Insert method inserts a new node into the tree, maintaining the binary search tree property. 
             
             
             * The Search method searches for a given data value in the tree, and the PreorderTraversal, InorderTraversal, and PostorderTraversal methods traverse the tree and print the data values of the nodes in preorder, inorder, and postorder, respectively. 
             
             
             * The Main method creates a new BinarySearchTree object and inserts some data values into it, then performs various operations on the tree.
             */
        }
    }
}
